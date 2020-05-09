/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RSG;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A0C0-0x0060A0D0
public class ResourceCache : SingletonMonoBehaviour<ResourceCache> // TypeDefIndex: 5820
{
	// Fields
	private static byte[] s_aSyncTempBuffer; // 0x00
	public static bool LogEnabled; // 0x08
	public static bool DontUseAssetBundle; // 0x09
	public static int DelayFrame; // 0x0C
	public Dictionary<string, Hash128> assetHashes; // 0x18
	public GameObject Container; // 0x20
	public Dictionary<string, Resource> Bundles; // 0x28
	public Dictionary<string, string[]> Dependencies; // 0x30
	private Dictionary<string, UnityEngine.Object> preloadAssets_; // 0x38

	// Nested types
	public class ResourceRefcountBehaviour : MonoBehaviour // TypeDefIndex: 5821
	{
		// Fields
		private Resource targetResource; // 0x18

		// Constructors
		public ResourceRefcountBehaviour() {} // 0x008357C0-0x008357D0

		// Methods
		public void SetTargetResource(Resource target) {} // 0x00832010-0x00832070
		private void OnDestroy() {} // 0x00835790-0x008357C0
	}

	public enum BundleLoadType // TypeDefIndex: 5822
	{
		LoadFromMemory = 0,
		LoadFromFile = 1
	}

	public abstract class Resource : IDisposable // TypeDefIndex: 5823
	{
		// Fields
		public string Name; // 0x10
		public float LastLoadTime; // 0x20
		public IPromise<Resource> OnLoaded; // 0x28

		// Properties
		public int RefCount { get; private set; } // 0x0082FC90-0x0082FCA0 0x00835620-0x00835630
		public bool Resident { get; private set; } // 0x00830680-0x00830690 0x00835630-0x00835640
		public bool CacheResident { get; private set; } // 0x0082F480-0x0082F490 0x00835640-0x00835650
		public bool IsLoaded { get; protected set; } // 0x00830BE0-0x00830BF0 0x00834D10-0x00834D20

		// Nested types
		public enum RemoveType // TypeDefIndex: 5824
		{
			Null = 0,
			Unload = 1
		}

		// Constructors
		protected Resource() {} // 0x00832450-0x00832460

		// Methods
		public abstract void LoadStart(byte[] shareBuffer, bool bForceSync, BundleLoadType loadType);
		public abstract UnityEngine.Object FindObject(string obj, Type type);
		public abstract UnityEngine.Object FindObjectNoCache(string obj, Type type);
		public abstract List<UnityEngine.Object> FindObjects(Type type);
		public abstract void ClearCache();
		public abstract bool RemoveCache(string objName, Type type, RemoveType removeType);
		public bool RemoveCache<T>(string obj, RemoveType removeType)
			where T : UnityEngine.Object => default;
		public abstract void ShowCache();
		public T FindObject<T>(string obj)
			where T : UnityEngine.Object => default;
		public T FindObjectNoCache<T>(string obj)
			where T : UnityEngine.Object => default;
		public List<T> FindObjects<T>()
			where T : UnityEngine.Object => default;
		public virtual void LoadAllAssets() {} // 0x00835650-0x00835660
		public virtual IPromise<int> LoadAllAssetsAsync() => default; // 0x00835660-0x008356B0
		public abstract void Dispose();
		public void EnableResident() {} // 0x008356B0-0x008356C0
		public void EnableCacheResident() {} // 0x008356C0-0x008356D0
		public void IncRef() {} // 0x00832BD0-0x00832D40
		public void DecRef() {} // 0x00830690-0x008306B0
		public void AttachRefCountToObject(GameObject ownerObj) {} // 0x008356D0-0x00835790
	}

	private class AssetBundleResource : Resource // TypeDefIndex: 5825
	{
		// Fields
		private AssetBundle bundle; // 0x30
		private bool loadallAsseted; // 0x38
		private Dictionary<uint, UnityEngine.Object> cache; // 0x40
		private Dictionary<uint, UnityEngine.Object> cacheFullName; // 0x48
		public List<Resource> dependencies; // 0x50
		public static HashSet<string> LoadedAssetBundleSet; // 0x00

		// Constructors
		public AssetBundleResource() {} // Dummy constructor
		public AssetBundleResource(string name) {} // 0x00832150-0x00832270
		static AssetBundleResource() {} // 0x00834770-0x008347F0

		// Methods
		public static bool TryCreate(string filename, out Resource res) {
			res = default;
			return default;
		} // 0x0082FAA0-0x0082FB10
		private static string ToHex(byte[] bytes) => default; // 0x00832270-0x008323D0
		private static string GetAssetPath() => default; // 0x008323D0-0x008323E0
		public static string PlatformDir() => default; // 0x008323E0-0x00832450
		public override void LoadStart(byte[] shareBuffer, bool bForceSync, BundleLoadType loadType) {} // 0x00832460-0x00832BC0
		private static IPromise<AssetBundle> LoadAssetBundle_(string path, string name, byte[] shareBuffer, bool bForceSync, BundleLoadType loadType) => default; // 0x00832D50-0x00833620
		// [IteratorStateMachine] // 0x00645CA0-0x00645D10
		private static IEnumerator waitLoadFileAsync_(string fileName, byte[] shareBuffer, Action<byte[]> endCb) => default; // 0x00833760-0x008337E0
		private static void LoadFileAsync_(string fileName, byte[] shareBuffer, Action<byte[]> endCb) {} // 0x00833810-0x00833910
		public static IPromise<AssetBundle> WaitBundlePromise_(AssetBundleCreateRequest bundleLoadRequest, string path, string name) => default; // 0x00833630-0x00833750
		// [IteratorStateMachine] // 0x00645D10-0x00645D80
		private static IEnumerator waitBundle_(Promise<AssetBundle> promise, AssetBundleCreateRequest bundleLoadRequest, string path, string name) => default; // 0x00833920-0x008339A0
		public override UnityEngine.Object FindObject(string objname, Type type) => default; // 0x008339D0-0x008339E0
		public override UnityEngine.Object FindObjectNoCache(string objname, Type type) => default; // 0x00833C70-0x00833C80
		public override List<UnityEngine.Object> FindObjects(Type type) => default; // 0x00833C80-0x00833C90
		private uint ConvertCacheKey_(UnityEngine.Object asset, uint explicitKeyHash) => default; // 0x00833E90-0x00834030
		private uint AddAsset_(UnityEngine.Object asset, bool bCache, uint explicitKeyHash) => default; // 0x00834030-0x008340C0
		private UnityEngine.Object FindObject_(string objname, Type type, bool bCache) => default; // 0x008339E0-0x00833C70
		private List<UnityEngine.Object> FindObjects_(Type type) => default; // 0x00833C90-0x00833E90
		public override void ClearCache() {} // 0x008340C0-0x00834120
		public override bool RemoveCache(string objName, Type type, RemoveType removeType) => default; // 0x00834120-0x00834240
		public override void ShowCache() {} // 0x00834240-0x00834350
		public override void LoadAllAssets() {} // 0x00834350-0x008344A0
		public override IPromise<int> LoadAllAssetsAsync() => default; // 0x008344A0-0x008345A0
		public override void Dispose() {} // 0x008345B0-0x00834770
	}

	// Constructors
	public ResourceCache() {} // 0x008319C0-0x00831AD0
	static ResourceCache() {} // 0x00831AD0-0x00831B60

	// Methods
	private void OnEnable() {} // 0x0082EF30-0x0082EFA0
	// [Conditional] // 0x00622090-0x006220D0
	public static void Log(object obj) {} // 0x0082EFA0-0x0082F010
	public void Update() {} // 0x0082F010-0x0082F020
	public void Setup() {} // 0x0082F020-0x0082F0B0
	private void LoadDependencies_() {} // 0x0082F0B0-0x0082F2B0
	public static void ClearAllCache() {} // 0x0082F2B0-0x0082F320
	private void DoClearAllCache() {} // 0x0082F320-0x0082F480
	private IPromise<UnityEngine.Object> LoadOrCreateObject(string name, Type type, bool isCreate, GameObject refCountOwner = null) => default; // 0x0082F490-0x0082F5D0
	private static string[] SplitResourceName(string name) => default; // 0x0082F5E0-0x0082F7E0
	private Resource LoadResourceStart(string filename, byte[] shareBuffer, bool bForceSync, BundleLoadType loadType) => default; // 0x0082F7E0-0x0082FAA0
	private void DoReleaseForce(string filename) {} // 0x0082FB10-0x0082FBC0
	private void DoRelease(string filename) {} // 0x0082FBC0-0x0082FC90
	private void DoReleaseAll(float forceDelay = -1f /* Metadata: 0x00612031 */) {} // 0x0082FCA0-0x00830670
	private void DoReleaseAllForce() {} // 0x008306B0-0x008307F0
	private void DoShowStatus() {} // 0x008307F0-0x00830920
	public static Resource GetBundle(string name) => default; // 0x00828BF0-0x00828C60
	public static bool IsBundleLoaded(string name) => default; // 0x00830AE0-0x00830BE0
	private static Resource GetBundle(string name, bool bLoadedCheck) => default; // 0x00830920-0x00830AE0
	public static bool IsExistBundle(string name) => default; // 0x00830BF0-0x00830D30
	private bool IsExistResource(string name) => default; // 0x00830D30-0x00830DD0
	public static bool IsExistResourceHandle(string name) => default; // 0x00830DD0-0x00830EE0
	private bool IsExistResourceHandleCore(string name) => default; // 0x00830EE0-0x00830F50
	public static IPromise<Resource> LoadBundle(string name) => default; // 0x00830F50-0x00831010
	public static IPromise<Resource> LoadBundleFromFile(string name) => default; // 0x00831010-0x008310D0
	public static Resource LoadBundleSync(string name) => default; // 0x008310D0-0x00831190
	public static IPromise<Resource> LoadBundleASync(string name) => default; // 0x00831190-0x00831220
	public static IPromise<Resource> LoadBundleASyncShareBuffer(string name, byte[] shareBuffer) => default; // 0x00831220-0x008312C0
	public static IPromise<Resource> LoadBundleASyncFromFile(string name) => default; // 0x008312C0-0x00831350
	public static T LoadSync<T>(string name)
		where T : UnityEngine.Object => default;
	public static T LoadSync<T>(string assetBundleName, string name)
		where T : UnityEngine.Object => default;
	public static IPromise<T> Create<T>(string name)
		where T : UnityEngine.Object => default;
	public void PreloadAsset(string assetbundleName, UnityEngine.Object obj) {} // 0x00831350-0x008313E0
	private UnityEngine.Object LoadPreloadedSync(string assetbundleName, string assetName) => default; // 0x008313E0-0x00831480
	public static void ReleaseForce(string filename) {} // 0x00831480-0x008315B0
	public static void ReleaseAllForce() {} // 0x008315B0-0x00831660
	public static void Release(string filename) {} // 0x00831660-0x008317B0
	public static void ReleaseAll(float forceDelay = -1f /* Metadata: 0x00612035 */) {} // 0x008317B0-0x00831870
	public static void ShowStatus() {} // 0x00831870-0x00831920
	public static ulong GetStringHash64fn(string p) => default; // 0x00831920-0x008319B0
	public static string GetStringHash(string p) => default; // 0x008319B0-0x008319C0
}

