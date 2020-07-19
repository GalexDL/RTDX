using System.Reflection;
using UnityEngine;
using UnityEngine.Animations;

public static class JointConstraintHelper
{
    public static void AddConstraints(Transform source, Transform target)
    {
        // Add position constraint to pelvis for foot correction
        var sourcePelvis = source.FindDeepChild("Pelvis");
        var targetPelvis = target.FindDeepChild("Pelvis");
        var positionConstraint = targetPelvis.gameObject.AddComponent<PositionConstraint>();
        positionConstraint.AddSource(new ConstraintSource { sourceTransform = sourcePelvis, weight = 1 });
        typeof(PositionConstraint)
            .GetMethod("ActivateAndPreserveOffset", BindingFlags.Instance | BindingFlags.NonPublic)
            .Invoke(positionConstraint, new object []{});
        
        // Replicate scale animations with scale constraint on the root
        var sourceRoot = source.FindDeepChild("PG_root");
        var targetRoot = target.FindDeepChild("PG_root");
        
        var scaleConstraint = targetRoot.gameObject.AddComponent<ScaleConstraint>();
        scaleConstraint.AddSource(new ConstraintSource { sourceTransform = sourceRoot, weight = 1 });
        typeof(ScaleConstraint)
            .GetMethod("ActivateAndPreserveOffset", BindingFlags.Instance | BindingFlags.NonPublic)
            .Invoke(scaleConstraint, new object []{});
        
        AddChildConstraints(sourceRoot, targetRoot);
    }

    private static void AddChildConstraints(Transform source, Transform target)
    {
        // Save the bind pose to restore it later
        target.gameObject.AddComponent<BindposeStore>().Activate();
        
        var constraint = target.gameObject.AddComponent<RotationConstraint>();

        constraint.AddSource(new ConstraintSource { sourceTransform = source, weight = 1 });
        typeof(RotationConstraint)
            .GetMethod("ActivateAndPreserveOffset", BindingFlags.Instance | BindingFlags.NonPublic)
            .Invoke(constraint, new object []{});

        foreach (Transform sourceChild in source)
        {
            var destinationChild = target.Find(sourceChild.name);
            if (destinationChild != null)
            {
                AddChildConstraints(sourceChild, destinationChild);
            }
        }
    }

    /// <summary>
    /// Moves the target root to make sure that the feet are at the same height as the source model.
    /// Helps avoid foot clipping.
    /// </summary>
    public static void ApplyFootCorrection(Transform source, Transform target)
    {
        var targetPelvis = target.FindDeepChild("Pelvis");
        var positionConstraint = targetPelvis.GetComponent<PositionConstraint>();
        if (positionConstraint == null)
            return;

        // HACK: don't correct the foot position if a scale animation is playing since it would cause floating
        var sourceRoot = source.FindDeepChild("PG_root");
        var sourceRootScale = sourceRoot.localScale;
        if (sourceRootScale.x > 1 || sourceRootScale.y > 1 || sourceRootScale.z > 1)
            return;

        var sourceFootLeft = source.FindDeepChild("L_Foot");
        var sourceFootRight = source.FindDeepChild("R_Foot");
        var targetFootLeft = target.FindDeepChild("L_Foot");
        var targetFootRight = target.FindDeepChild("R_Foot");

        if (sourceFootLeft == null || sourceFootRight == null)
        {
            sourceFootLeft = source.FindDeepChild("L_Calf");
            sourceFootRight = source.FindDeepChild("R_Calf");
            targetFootLeft = target.FindDeepChild("L_Calf");
            targetFootRight = target.FindDeepChild("R_Calf");
        }

        if (sourceFootLeft == null || sourceFootRight == null)
            return;

        var sourceAverageY = (sourceFootLeft.position.y + sourceFootRight.position.y) * 0.5f;
        var targetAverageY = (targetFootLeft.position.y + targetFootRight.position.y) * 0.5f;

        float delta = sourceAverageY - targetAverageY + positionConstraint.translationOffset.y;

        positionConstraint.locked = false;
        positionConstraint.translationOffset = new Vector3(0, delta, 0);
        positionConstraint.locked = true;
    }
}
