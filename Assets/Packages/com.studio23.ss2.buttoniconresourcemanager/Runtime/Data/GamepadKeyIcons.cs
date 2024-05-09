using UnityEngine;

namespace Studio23.SS2.ButtonIconResourceManager.Data
{
	[CreateAssetMenu(fileName = "KeyIcons-{KeyName}", menuName = "Studio-23/Button Icon Resource Manager/GamePad Key Icons")]
	public class GamepadKeyIcons : ScriptableObject
	{
		[SerializeField]
		private Sprite _xboxIcon;
		[SerializeField]
		private Sprite _playstationIcon;
		public string ControlPath;

		public void Initialize(Sprite xboxIcon, Sprite playstationIcon, string controlPath)
		{
			_xboxIcon = xboxIcon;
			_playstationIcon = playstationIcon;
			if (controlPath.Contains("-"))
				controlPath = controlPath.Replace("-", "/");
			ControlPath = controlPath;
		}

		public Sprite GetIcon(Platform platform)
		{
			switch (platform)
			{
				case Platform.XBOX:
					return _xboxIcon;
				case Platform.PLAYSTATION:
					return _playstationIcon;
				default:
					return null;
			}
		}

		public Sprite GetIcon(string platformName)
		{
			string platform = platformName.ToLower();
			if (platform.Contains("playstation") || platform.Contains("dual"))
				return _playstationIcon;
			else if (platform.Contains("xbox") || platform.Contains("xinput") || platform.Contains("gamepad"))
				return _xboxIcon;
			else
				return _xboxIcon;
		}
	}
}