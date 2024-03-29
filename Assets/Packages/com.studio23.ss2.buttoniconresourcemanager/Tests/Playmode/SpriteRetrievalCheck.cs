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

	[UnityTest]
	public IEnumerator _String_Based_Sprite_Retrieval_Check_LeftStickPress_Playstation_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("Playstation", "leftStickPress");
		Assert.AreEqual("leftStickPress", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _String_Based_Retrieval_ButtonNorth_Xbox_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("Xbox", "buttonNorth");
		Assert.AreEqual("buttonNorth", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _String_Based_Retrieval_Xinput_Device_Layout_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("XInput", "buttonNorth");
		Assert.AreEqual("buttonNorth", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _String_Based_Retrieval_DualShock_Device_Layout_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("dual", "buttonNorth");
		Assert.AreEqual("buttonNorth", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _String_Based_Retrieval_playstation_Device_Layout_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("plaYstation", "buttonNorth");
		Assert.AreEqual("buttonNorth", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _String_Based_Retrieval_Xbox_Right_Stick_Up_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("Xbox", "rightStick/up");
		Assert.AreEqual("rightStick-up", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _String_Based_Retrieval_Xbox_Left_Stick_Right_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("Xbox", "leftStick/right");
		Assert.AreEqual("leftStick-right", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _String_Based_Retrieval_Playstation_Dpad_Down_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("playstation", "dpad/down");
		Assert.AreEqual("dpad-down", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _Unexpected_Platform_Name_Dpad_Up_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("failsafe", "dpad/up");
		Assert.AreEqual("dpad-up", retrievedIcon.name);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _Empty_Or_Null_Platform_Name_Dpad_Left_()
	{
		var retrievedIcon = KeyIconManager.Instance.GetIcon("", "dpad/left");
		Assert.AreEqual("dpad-left", retrievedIcon.name);
		yield return null;
	}
}