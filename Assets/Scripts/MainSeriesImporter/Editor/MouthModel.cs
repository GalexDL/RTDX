using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class MouthModel
{
    public const int MouthPoseCount = 6;

    private TransformStore _originalTransform;
    private TransformStore[] _poses;
    private int _currentPoseIndex;
    
    private List<JointHelper> _jointHelpers = new List<JointHelper>();

    public int CurrentPoseIndex
    {
        get => _currentPoseIndex;
        set
        {
            CurrentPose.SavePosition();
            _currentPoseIndex = value;
            _poses[value].Sample();
        }
    }

    public IReadOnlyList<JointHelper> JointHelpers => _jointHelpers;
    
    private TransformStore CurrentPose => _poses[_currentPoseIndex];

    public MouthModel(Transform rootJaw)
    {
        _originalTransform = new TransformStore(rootJaw);
        _poses = new TransformStore[MouthPoseCount];
        for (int i = 0; i < MouthPoseCount; i++)
        {
            _poses[i] = new TransformStore(rootJaw);
        }
        
        AddRotationJointHelperIfAvailable("UpperJaw");
        AddRotationJointHelperIfAvailable("LowerJaw");

        AddPositionJointHelpers(rootJaw);
    }
    
    public void ResetTransform()
    {
        _originalTransform.Sample();
        CurrentPose.CopyFrom(_originalTransform);
        CurrentPose.Sample();
    }

    public void SelectAndExpandRoot()
    {
        var go = _originalTransform.UnderlyingTransform.gameObject;
        EditorGUIHelpers.SetHierarchyExpanded(go, true);
        EditorGUIUtility.PingObject(go);
        Selection.activeGameObject = go;
    }

    public void Mirror(JointHelper source)
    {
        var target = GetMirroringJoint(source);
        if (target != null)
        {
            target.Value = source.Value;
        }
    }

    public bool IsJointMirrored(JointHelper source)
    {
        return _jointHelpers.Any(helper => helper != source 
            && helper.Name == "L" + source.Name.Substring(1)
            && IsSameJointHelperType(source, helper));
    }

    public void SelectJoint(JointHelper joint, bool mirrored)
    {
        var selectedJoints = new List<Object>();
        selectedJoints.Add(joint.JointTransform.gameObject);

        var mirroringJoint = GetMirroringJoint(joint);
        if (mirrored && mirroringJoint != null)
        {
            selectedJoints.Add(mirroringJoint.JointTransform.gameObject);
        }

        Selection.objects = selectedJoints.ToArray();
    }
    
    private JointHelper GetMirroringJoint(JointHelper source)
    {
        return _jointHelpers.FirstOrDefault(helper => helper != source
                                               && helper.Name == "R" + source.Name.Substring(1)
                                               && IsSameJointHelperType(source, helper));
    }

    private void AddRotationJointHelperIfAvailable(string name)
    {
       var rootTransform = _originalTransform.UnderlyingTransform;
       var targetJoint = rootTransform.FindDeepChild(name);
       if (targetJoint != null)
       {
           _jointHelpers.Add(new RotationJointHelper(targetJoint));
       }
    }

    private void AddPositionJointHelpers(Transform current)
    {
        if (!_jointHelpers.Any(helper => helper.Name == current.name))
        {
            _jointHelpers.Add(new TranslationJointHelper(current, Axis.Y));
            _jointHelpers.Add(new TranslationJointHelper(current, Axis.Z));
        }

        foreach (Transform child in current)
        {
            AddPositionJointHelpers(child);
        }
    }

    private bool IsSameJointHelperType(JointHelper a, JointHelper b)
    {
        return a.GetType() == b.GetType()
               && (!(a is TranslationJointHelper) || !(b is TranslationJointHelper))
               || (a as TranslationJointHelper)?.Axis == (b as TranslationJointHelper)?.Axis;
    }

    public class TransformStore
    {
        public List<TransformStore> Children { get; } = new List<TransformStore>();

        public Vector3 LocalPosition { get; set; }
        public Quaternion LocalRotation { get; set; }

        public Transform UnderlyingTransform { get; }

        public TransformStore(Transform transform)
        {
            LocalPosition = transform.localPosition;
            LocalRotation = transform.localRotation;
            UnderlyingTransform = transform;
            
            foreach (Transform child in transform)
            {
                Children.Add(new TransformStore(child));
            }
        }

        public void Sample()
        {
            UnderlyingTransform.localPosition = LocalPosition;
            UnderlyingTransform.localRotation = LocalRotation;

            foreach (var child in Children)
            {
                child.Sample();
            }
        }

        public void SavePosition()
        {
            LocalPosition = UnderlyingTransform.localPosition;
            LocalRotation = UnderlyingTransform.localRotation;
            
            foreach (var child in Children)
            {
                child.SavePosition();
            }
        }

        public void CopyFrom(TransformStore source)
        {
            LocalPosition = source.LocalPosition;
            LocalRotation = source.LocalRotation;

            for (int i = 0; i < Children.Count; i++)
            {
                Children[i].CopyFrom(source.Children[i]);
            }
        }
    }

    public abstract class JointHelper
    {
        public abstract float Value { get; set; }
        protected float InitialValue { get; set; }
        
        public abstract float MinValue { get; }
        public abstract float MaxValue { get; }
        public string Name => JointTransform.name;
        public abstract string PropertyName { get; }

        public Transform JointTransform { get; }

        protected JointHelper(Transform jointTransform)
        {
            JointTransform = jointTransform;
        }
    }

    [UsedImplicitly]
    public sealed class RotationJointHelper : JointHelper
    {
        public override float Value
        {
            get => JointTransform.localEulerAngles.y;
            set => JointTransform.localEulerAngles
                = new Vector3(JointTransform.localEulerAngles.x, value, JointTransform.localEulerAngles.z);
        }
        public override string PropertyName => "local Y rot";

        public override float MinValue => InitialValue - 50f;
        public override float MaxValue => InitialValue + 50f;
        
        public RotationJointHelper(Transform jointTransform) : base(jointTransform)
        {
            InitialValue = Value;
        }
    }
    
    
    [UsedImplicitly]
    public sealed class TranslationJointHelper : JointHelper
    {
        public Axis Axis { get; }

        public override float Value
        {
            get
            {
                switch (Axis)
                {
                    case Axis.X:
                        return JointTransform.position.x;
                    case Axis.Y:
                        return JointTransform.position.y;
                    case Axis.Z:
                        return JointTransform.position.z;
                }

                return 0;
            }
            set
            {
                var pos = JointTransform.position;

                switch (Axis)
                {
                    case Axis.X:
                        pos.x = value;
                        break;
                    case Axis.Y:
                        pos.y = value;
                        break;
                    case Axis.Z:
                        pos.z = value;
                        break;
                }
                
                JointTransform.position = pos;
            }
        }

        public override string PropertyName => Axis + " pos";

        public override float MinValue => InitialValue - 0.1f;
        public override float MaxValue => InitialValue + 0.1f;
        
        public TranslationJointHelper(Transform jointTransform, Axis axis) : base(jointTransform)
        {
            Axis = axis;
            InitialValue = Value;
        }
    }
}