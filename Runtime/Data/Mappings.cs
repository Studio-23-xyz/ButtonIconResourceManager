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
			KeyControlPathMap[Buttons.DPAD_UP] = "dpadUp";
			KeyControlPathMap[Buttons.DPAD_RIGHT] = "dpadRight";
			KeyControlPathMap[Buttons.DPAD_DOWN] = "dpadDown";
			KeyControlPathMap[Buttons.DPAD_LEFT] = "dpadLeft";

			KeyControlPathMap[Buttons.LEFT_SHOULDER] = "leftShoulder";
			KeyControlPathMap[Buttons.LEFT_TRIGGER] = "leftTrigger";
			KeyControlPathMap[Buttons.LEFT_STICK] = "leftStick";
			KeyControlPathMap[Buttons.LEFT_STICK_PRESS] = "leftStickPress";

			KeyControlPathMap[Buttons.RIGHT_SHOULDER] = "rightShoulder";
			KeyControlPathMap[Buttons.RIGHT_TRIGGER] = "rightTrigger";
			KeyControlPathMap[Buttons.RIGHT_STICK] = "rightStick";
			KeyControlPathMap[Buttons.RIGHT_STICK_PRESS] = "rightStickPress";

			KeyControlPathMap[Buttons.SELECT] = "select";
			KeyControlPathMap[Buttons.START] = "start";
		}

		public string GetControlPath(Buttons button)
		{
			return KeyControlPathMap[button];
		}
	}
}