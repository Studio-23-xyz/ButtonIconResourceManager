using Studio23.SS2.ButtonIconResourceManager.core;
using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;

public class SpriteRetrievalCheck
{
	[UnityTest]
	public IEnumerator _Xbox_Btn_South_Retrieval_Test_01_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("Xbox", "buttonSouth");
		Assert.AreEqual("buttonSouth", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _Xbox_Right_Shoulder_Retrieval_Test_01_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("Xbox", "rightShoulder");
		Assert.AreEqual("rightShoulder", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _PS_Btn_South_Retrieval_Test_01_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("Playstation", "buttonSouth");
		Assert.AreEqual("buttonSouth", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _PS_Right_Shoulder_Retrieval_Test_01_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("Playstation", "rightShoulder");
		Assert.AreEqual("rightShoulder", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _Xbox_Btn_Right_Stick_Press_Retrieval_Test_01_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("Xbox", "rightStickPress");
		Assert.AreEqual("rightStickPress", retrievedIcon.name);
		yield return null;
	}
}
