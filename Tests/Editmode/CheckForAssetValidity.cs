using NUnit.Framework;
using Studio23.SS2.ButtonIconResourceManager.Data;
using UnityEngine;

public class CheckForAssetValidity
{
	[Test]
	public void _Check_For_19_Sprite_Asset_In_ButtonIcons_PS_Folder_()
	{
		var psSprites = Resources.LoadAll<Texture2D>($"ButtonIcons/PS/");
		Assert.AreEqual(20, psSprites.Length);
	}

	[Test]
	public void _Check_For_19_KeyIcon_Asset_Exists_In_Directory_()
	{
		var scriptableObjects = Resources.LoadAll<KeyIcons>($"KeyIcons");
		Assert.AreEqual(20, scriptableObjects.Length);
	}
}
