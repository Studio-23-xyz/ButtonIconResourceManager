using com.studio23.ss2.buttoniconresourcemanager.Data;
using System.IO;
using UnityEditor;
using UnityEngine;

public class ButtonIconSOGenerator : EditorWindow
{
	[MenuItem("Window/Studio 23/ Button Icon Resource Manager/Create Button Scriptable Objects")]
	public static void CreateButtonSOs()
	{
		string xboxFolderPath = "Icons/Xbox";
		string playstationFolderPath = "Icons/PS";

		Sprite[] xboxSprites = Resources.LoadAll<Sprite>($"{xboxFolderPath}");
		Sprite[] psSprites = Resources.LoadAll<Sprite>($"{playstationFolderPath}");

		if (Directory.Exists($"Assets/Resources/KeyIcons/"))
		{
			Directory.Delete($"Assets/Resources/KeyIcons/", true);
		}
		Directory.CreateDirectory($"Assets/Resources/KeyIcons/");
		for (var i = 0; i < xboxSprites.Length; i++)
		{
			KeyIcons keyIcons = ScriptableObject.CreateInstance<KeyIcons>();
			var controlPath = xboxSprites[i].name;
			EditorUtility.SetDirty(keyIcons);
			keyIcons.Initialize(xboxSprites[i], psSprites[i], controlPath);

			AssetDatabase.CreateAsset(keyIcons, $"Assets/Resources/KeyIcons/{controlPath}.asset");
		}

		AssetDatabase.Refresh();
		AssetDatabase.SaveAssets();
	}
}
