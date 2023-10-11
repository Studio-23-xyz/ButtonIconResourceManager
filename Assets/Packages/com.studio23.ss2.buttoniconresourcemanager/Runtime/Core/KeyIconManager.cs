using Studio23.SS2.ButtonIconResourceManager.Data;
using UnityEngine;

namespace Studio23.SS2.ButtonIconResourceManager.core
{
	public class KeyIconManager : MonoBehaviour
	{
		private static KeyIconManager _instance;

		public static KeyIconManager Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = FindObjectOfType<KeyIconManager>();
					if (_instance == null)
					{
						GameObject obj = new GameObject("KeyIconManager");
						_instance = obj.AddComponent<KeyIconManager>();
						obj.name = "KeyIconManager";
					}
				}

				return _instance;
			}
		}

		public Sprite GetIcon(Platform platformName, Buttons button)
		{
			string path = $"KeyIcons/{new KeyMappings().GetControlPath(button)}";

			KeyIcons keyIcons = Resources.Load<KeyIcons>(path);
			if (keyIcons != null)
			{
				return keyIcons.GetIcon(platformName);
			}

			Debug.LogWarning($"Key icon not found for path: {path}");
			return null;
		}

		public Sprite GetIcon(string platformName, string controlPath)
		{
			string path = $"KeyIcons/{controlPath}";

			KeyIcons keyIcons = Resources.Load<KeyIcons>(path);
			if (keyIcons != null)
			{
				return keyIcons.GetIcon(platformName);
			}
			Debug.LogWarning($"Key icon not found for platform {platformName} & control path {controlPath}");
			return null;
		}
	}
}