/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

#if FALSE
public class GroundNaviPoint : MonoBehaviour // TypeDefIndex: 4895
{
	// Fields
	public GroundNaviPointAsset asset; // 0x18
	[NonSerialized]
	private PointLayerType currentLayer; // 0x20
	private FindPathWork_ findPathWork_; // 0x28
	private List<FindSortItem_> findTmpSortList_; // 0x30

	// Properties
	public List<WayPoint> wayPoints { get => default; } // 0x00733BF0-0x00733C00 
	public PointLayerType CurrentLayer { get => default; } // 0x00733C00-0x00733C10 


	// Nested types
	public enum PointLayerType // TypeDefIndex: 4896
	{
		ALL = 0,
		CAMP_NORMAL_LV1 = 1,
		CAMP_NORMAL_LV2 = 2,
		CAMP_NORMAL_LV3 = 3,
		CAMP_WATER_LV1 = 4,
		CAMP_WATER_LV2 = 5,
		CAMP_WATER_LV3 = 6,
		CAMP_FIRE_LV1 = 7,
		CAMP_FIRE_LV2 = 8,
		CAMP_FIRE_LV3 = 9,
		CAMP_GROUND_LV1 = 10,
		CAMP_GROUND_LV2 = 11,
		CAMP_GROUND_LV3 = 12,
		CAMP_GRASS_LV1 = 13,
		CAMP_GRASS_LV2 = 14,
		CAMP_GRASS_LV3 = 15
	}


	[Serializable]
	public class WayPoint // TypeDefIndex: 4897
	{
		// Fields
		public Vector2 pos; // 0x10
		public List<int> link; // 0x18
		public PointLayerType layerType; // 0x20
		[NonSerialized]
		public List<bool> linkEnable; // 0x28

		// Constructors
		public WayPoint() {} // 0x00734390-0x00734430
	}


	private struct FindSortItem_ // TypeDefIndex: 4898
	{
		// Fields
		public float len; // 0x10
		public WayPoint point; // 0x18
	}

	private class FindPathWork_ // TypeDefIndex: 4899
	{
		// Fields
		public WayPoint start; // 0x10
		public WayPoint goal; // 0x18
		public List<WayPoint> findPath; // 0x20
		public List<AstarItem_> openSortedSet; // 0x28
		public HashSet<WayPoint> closedSet; // 0x30
		public Dictionary<WayPoint, WayPoint> cameFromTbl; // 0x38
		public AstarItem_Cmp_ asterItemCmpFunc; // 0x40

		// Constructors
		public FindPathWork_() {} // 0x00735D90-0x00735EA0

		// Methods
		public void Clear() {} // 0x00735760-0x007357F0
	}

	private struct AstarItem_ // TypeDefIndex: 4900
	{
		// Fields
		public float gScore; // 0x10
		public float fScore; // 0x14
		public WayPoint point; // 0x18
	}

	private class AstarItem_Cmp_ : IComparer<AstarItem_> // TypeDefIndex: 4901
	{
		// Constructors
		public AstarItem_Cmp_() {} // 0x00736070-0x007360F0

		// Methods
		public int Compare(AstarItem_ a, AstarItem_ b) => default; // 0x00736030-0x00736070
	}

	// Constructors
	public GroundNaviPoint() {} // 0x00735D00-0x00735D90

	// Methods
	public void ApplyCalcNoMovePath(ActObjCharactor actObjCh) {} // 0x00733C10-0x00734190
	private void OnEnable() {} // 0x00734240-0x00734250
	private void OnDisable() {} // 0x00734250-0x00734260
	public WayPoint AddWayPoint() => default; // 0x00734260-0x00734390
	public void RemoveWayPoint(WayPoint waypoint) {} // 0x00734430-0x00734680
	public void LinkWayPoint(WayPoint waypointA, WayPoint waypointB) {} // 0x00734680-0x00734800
	public void UnlinkWayPoint(WayPoint waypointA, WayPoint waypointB) {} // 0x00734800-0x007349C0
	public void FindGoal(out WayPoint goalPoint, ActObjCharactor chara, Vector2 goal2d) {
		goalPoint = default;
	} // 0x007349C0-0x00734E20
	public void FindPath(ref List<WayPoint> findList, ActObjCharactor chara, Vector2 goal2d) {} // 0x00734E20-0x00735760
	private void FindPathAstar_() {} // 0x007357F0-0x00735CE0
	private Vector3 CalcGroundPos3d_(Vector2 pos2d) => default; // 0x00734190-0x00734220
	private void OnDrawGizmosSelected() {} // 0x00735CF0-0x00735D00
}
#endif