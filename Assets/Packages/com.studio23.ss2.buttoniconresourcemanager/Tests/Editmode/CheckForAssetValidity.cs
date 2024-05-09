using NUnit.Framework;
using Studio23.SS2.ButtonIconResourceManager.Data;
using UnityEngine;

public class CheckForAssetValidity
{
	[Test]
	public void _Check_For_28_Sprite_Asset_In_ButtonIcons_PS_Folder_()
	{
		var psSprites = Resources.LoadAll<Texture2D>($"ButtonIcons/PS/");
		Assert.AreEqual(28, psSprites.Length);
	}

	[Test]
	public void _Check_For_No_Empty_Control_Path_()
	{
		var scriptableObjects = Resources.LoadAll<GamepadKeyIcons>($"KeyIcons");
		bool isValid = true;
		foreach (var iconObj in scriptableObjects)
		{
			if (string.IsNullOrEmpty(iconObj.ControlPath))
			{
				isValid = false;
				break;
			}
		}
		Assert.AreEqual(true, isValid);
	}

	[Test]
	public void _Check_For_28_KeyIcon_Asset_Exists_In_Directory_()
	{
		var scriptableObjects = Resources.LoadAll<GamepadKeyIcons>($"KeyIcons");
		Assert.AreEqual(28, scriptableObjects.Length);
	}
}
