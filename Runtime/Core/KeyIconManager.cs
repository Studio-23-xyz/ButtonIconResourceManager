using com.studio23.ss2.buttoniconresourcemanager.Data;
using UnityEngine;

namespace com.studio23.ss2.buttoniconresourcemanager.core
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

		public Sprite GetIcon(string platformName, string controlPath)
		{
			string path = $"KeyIcons/{controlPath}";

			KeyIcons keyIcons = Resources.Load<KeyIcons>(path);
			if (keyIcons != null)
			{
				return keyIcons.GetIcon(platformName);
			}

			Debug.LogWarning($"Key icon not found for path: {path}");
			return null;
		}
	}
}