using NUnit.Framework;
using Studio23.SS2.ButtonIconResourceManager.core;
using Studio23.SS2.ButtonIconResourceManager.Data;
using System.Collections;
using UnityEngine.TestTools;

public class SpriteRetrievalCheck
{
	[UnityTest]
	public IEnumerator _Xbox_Btn_South_Retrieval_Test_01_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon(Platform.XBOX, Buttons.BUTTON_SOUTH);
		Assert.AreEqual("buttonSouth", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _Xbox_Right_Shoulder_Retrieval_Test_01_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon(Platform.XBOX, Buttons.RIGHT_SHOULDER);
		Assert.AreEqual("rightShoulder", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _PS_Btn_South_Retrieval_Test_01_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon(Platform.PLAYSTATION, Buttons.BUTTON_SOUTH);
		Assert.AreEqual("buttonSouth", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _PS_Right_Shoulder_Retrieval_Test_01_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon(Platform.PLAYSTATION, Buttons.RIGHT_SHOULDER);
		Assert.AreEqual("rightShoulder", retrievedIcon.name);
		yield return null;
	}
}
