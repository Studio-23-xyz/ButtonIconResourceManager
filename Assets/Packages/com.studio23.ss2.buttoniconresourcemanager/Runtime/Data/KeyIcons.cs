using UnityEngine;

namespace com.studio23.ss2.buttoniconresourcemanager.Data
{
	[CreateAssetMenu(fileName = "KeyIcons-{KeyName}", menuName = "Studio 23/Button Icon Resource Manager/Key Icons")]
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

		public Sprite GetIcon(string platform)
		{
			switch (platform)
			{
				case "Xbox":
					return _xboxIcon;
				case "Playstation":
					return _playstationIcon;
				default:
					return null;
			}
		}
	}
}