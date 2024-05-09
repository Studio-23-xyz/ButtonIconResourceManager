using Studio23.SS2.ButtonIconResourceManager.Data;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Studio23.SS2.ButtonIconResourceManager.Editor
{
	public class ButtonIconSOGenerator : EditorWindow
	{
		[MenuItem("Studio-23/Button Icon Resource Manager/Create ButtonIcon Objects")]
		public static void CreateButtonSOs()
		{
            string keyBoardFolderPath = "ButtonIcons/KeyBoard";
            string xboxFolderPath = "ButtonIcons/Xbox";
			string playstationFolderPath = "ButtonIcons/PS";

            Sprite[] keyBoardSprites = Resources.LoadAll<Sprite>($"{keyBoardFolderPath}");
            Sprite[] xboxSprites = Resources.LoadAll<Sprite>($"{xboxFolderPath}");
			Sprite[] psSprites = Resources.LoadAll<Sprite>($"{playstationFolderPath}");

			if (Directory.Exists($"Assets/Resources/KeyIcons/"))
			{
				Directory.Delete($"Assets/Resources/KeyIcons/", true);
			}

			Directory.CreateDirectory($"Assets/Resources/KeyIcons/GamePad/");
			for (var i = 0; i < xboxSprites.Length; i++)
			{
				KeyIcons keyIcons = CreateInstance<KeyIcons>();
				var controlPath = xboxSprites[i].name;
				EditorUtility.SetDirty(keyIcons);
				keyIcons.Initialize(xboxSprites[i], psSprites[i], controlPath);

				AssetDatabase.CreateAsset(keyIcons, $"Assets/Resources/KeyIcons/GamePad/{controlPath}.asset");
			}

            Directory.CreateDirectory($"Assets/Resources/KeyIcons/KeyBoard/");
            for (var i = 0; i < keyBoardSprites.Length; i++)
            {
                KeyBoardIcons keyIcons = CreateInstance<KeyBoardIcons>();
                var controlPath = keyBoardSprites[i].name;
                EditorUtility.SetDirty(keyIcons);
                keyIcons.Initialize(keyBoardSprites[i], controlPath);

                AssetDatabase.CreateAsset(keyIcons, $"Assets/Resources/KeyIcons/KeyBoard/{controlPath}.asset");
            }

            AssetDatabase.Refresh();
			AssetDatabase.SaveAssets();
		}
	}
}