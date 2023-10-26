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

		/// <summary>
		/// Retrieves the sprite associated with the given platform enum and button enum. This can be used if you want to show a button arbitrarily without counting for rebinds.
		/// </summary>
		/// <param name="platformName">The controller layout to use.</param>
		/// <param name="button">Name of the button icon to retrieve</param>
		/// <returns>Returns a sprite of associated with the controller specific to the given platform and button.</returns>
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

		/// <summary>
		/// If you want to account for potential rebinds of a button and want to update the button icon dynamically when it has been rebinded, use this method. 
		/// </summary>
		/// <param name="platformName">String formatted name of the platform. This dictates which layout to use.</param>
		/// <param name="controlPath">Button name in string format which is set accordingly by the Input System.</param>
		/// <returns>Returns a sprite of associated with the controller specific to the given platform and button.</returns>
		public Sprite GetIcon(string platformName, string controlPath)
		{
			if (controlPath.Contains("/"))
				controlPath = controlPath.Replace("/","-");
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