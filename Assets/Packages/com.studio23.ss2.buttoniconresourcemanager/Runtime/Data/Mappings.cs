using System.Collections.Generic;

namespace Studio23.SS2.ButtonIconResourceManager.Data
{
	internal class KeyMappings
	{
		private Dictionary<Buttons, string> KeyControlPathMap;

		public KeyMappings()
		{
			KeyControlPathMap = new Dictionary<Buttons, string>();

			KeyControlPathMap[Buttons.BUTTON_EAST] = "buttonEast";
			KeyControlPathMap[Buttons.BUTTON_WEST] = "buttonWest";
			KeyControlPathMap[Buttons.BUTTON_NORTH] = "buttonNorth";
			KeyControlPathMap[Buttons.BUTTON_SOUTH] = "buttonSouth";

			KeyControlPathMap[Buttons.DPAD] = "dpad";
			KeyControlPathMap[Buttons.DPAD_UP] = "dpad/up";
			KeyControlPathMap[Buttons.DPAD_RIGHT] = "dpad/right";
			KeyControlPathMap[Buttons.DPAD_DOWN] = "dpad/down";
			KeyControlPathMap[Buttons.DPAD_LEFT] = "dpad/left";

			KeyControlPathMap[Buttons.LEFT_SHOULDER] = "leftShoulder";
			KeyControlPathMap[Buttons.LEFT_TRIGGER] = "leftTrigger";
			KeyControlPathMap[Buttons.LEFT_STICK] = "leftStick";
			KeyControlPathMap[Buttons.LEFT_STICK_PRESS] = "leftStickPress";

			KeyControlPathMap[Buttons.LEFT_STICK_UP] = "leftStick/up";
			KeyControlPathMap[Buttons.LEFT_STICK_DOWN] = "leftStick/down";
			KeyControlPathMap[Buttons.LEFT_STICK_LEFT] = "leftStick/left";
			KeyControlPathMap[Buttons.LEFT_STICK_RIGHT] = "leftStick/right";

			KeyControlPathMap[Buttons.RIGHT_SHOULDER] = "rightShoulder";
			KeyControlPathMap[Buttons.RIGHT_TRIGGER] = "rightTrigger";
			KeyControlPathMap[Buttons.RIGHT_STICK] = "rightStick";
			KeyControlPathMap[Buttons.RIGHT_STICK_PRESS] = "rightStickPress";

			KeyControlPathMap[Buttons.RIGHT_STICK_UP] = "rightStick/up";
			KeyControlPathMap[Buttons.RIGHT_STICK_DOWN] = "rightStick/down";
			KeyControlPathMap[Buttons.RIGHT_STICK_LEFT] = "rightStick/left";
			KeyControlPathMap[Buttons.RIGHT_STICK_RIGHT] = "rightStick/right";

			KeyControlPathMap[Buttons.SELECT] = "select";
			KeyControlPathMap[Buttons.START] = "start";
			KeyControlPathMap[Buttons.EXCLUSIVE] = "controllerExclusive";
		}

		public string GetControlPath(Buttons button)
		{
			return KeyControlPathMap[button];
		}
	}
}