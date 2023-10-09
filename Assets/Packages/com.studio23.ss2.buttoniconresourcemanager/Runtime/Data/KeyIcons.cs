using UnityEngine;

namespace Studio23.SS2.ButtonIconResourceManager.Data
{
	[CreateAssetMenu(fileName = "KeyIcons-{KeyName}", menuName = "Studio-23/Button Icon Resource Manager/Key Icons")]
	public class KeyIcons : ScriptableObject
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
	}
}