using System.Collections.Generic;

namespace Studio23.SS2.ButtonIconResourceManager.Data
{
    internal class KeyIconMappings
    {
        private readonly Dictionary<string, string> _keyCharacterMappings;

        public KeyIconMappings()
        {
            _keyCharacterMappings = new Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase)
            {
                // Numbers
                { "0", "numpad0" },
                { "1", "numpad1" },
                { "2", "numpad2" },
                { "3", "numpad3" },
                { "4", "numpad4" },
                { "5", "numpad5" },
                { "6", "numpad6" },
                { "7", "numpad7" },
                { "8", "numpad8" },
                { "9", "numpad9" },

                { "Num 0", "numpad0" },
                { "Num 1", "numpad1" },
                { "Num 2", "numpad2" },
                { "Num 3", "numpad3" },
                { "Num 4", "numpad4" },
                { "Num 5", "numpad5" },
                { "Num 6", "numpad6" },
                { "Num 7", "numpad7" },
                { "Num 8", "numpad8" },
                { "Num 9", "numpad9" },

                // Modifiers
                { "Left Shift", "shift" },
                { "Right Shift", "shift" },
                { "Shift", "shift" },

                { "Left Ctrl", "ctrl" },
                { "Right Ctrl", "ctrl" },
                { "Ctrl", "ctrl" },
                { "Control", "ctrl" },

                { "Left Alt", "alt" },
                { "Right Alt", "alt" },
                { "Alt", "alt" },

                { "Left Windows", "leftMeta" },
                { "Right Windows", "leftMeta" },
                { "Windows", "leftMeta" },
                { "Left Meta", "leftMeta" },
                { "Right Meta", "leftMeta" },

                // Navigation
                { "Up Arrow", "upArrow" },
                { "Down Arrow", "downArrow" },
                { "Left Arrow", "leftArrow" },
                { "Right Arrow", "rightArrow" },
                { "Up", "upArrow" },
                { "Down", "downArrow" },
                { "Left", "leftArrow" },
                { "Right", "rightArrow" }, 
                
                { "Page Up", "pageUp" },
                { "Page Down", "pageDown" },

                // Editing
                { "Backspace", "backspace" },
                { "Enter", "enter" },
                { "Num Enter", "numpadEnter" },
                { "Escape", "escape" },
                { "Esc", "escape" },
                { "Caps Lock", "capsLock" },

                // Numpad Operators
                { "Num +", "numpadPlus" },
                { "+", "numpadPlus" },
                { "Num -", "numpadMinus" },
                { "Num *", "numpadMultiply" },
                { "*", "numpadMultiply" },
                { "Num /", "numpadDivide" },
                { "Num del", "period" },

                // Symbols
                { "-", "minus" },
                { "=", "equals" },
                { "[", "leftBracket" },
                { "]", "rightBracket" },
                { "\\", "backslash" },
                { ";", "semicolon" },
                { "'", "quote" },
                { ",", "comma" },
                { ".", "period" },
                { "/", "slash" },
                { "`", "backquote" },

                // Misc
                { "Print Screen", "printScreen" },
                { "Scroll Lock", "scrollLock" },
                
                // Mouse
                {"LMB", "mouse0"},
                {"RMB", "mouse1"},
                {"MMB", "mouse2"},
                {"delta", "mouse"},
                {"position", "mouse"},
                {"forward", "mouse"},
                {"back", "mouse"},
                
                // GamePad
                {"LS/Up","LSUp"},
                {"LS/Down","LSDown"},
                {"LS/Left","LSLeft"},
                {"LS/Right","LSRight"},
                {"RS/Up","RSUp"},
                {"RS/Down","RSDown"},
                {"RS/Left","RSLeft"},
                {"RS/Right","RSRight"},
                {"D-Pad/Up","D-PadUp"},
                {"D-Pad/Down","D-PadDown"},
                {"D-Pad/Left","D-PadLeft"},
                {"D-Pad/Right","D-PadRight"},
                {"LS/X","LSX"},
                {"LS/Y","LSY"},
                {"RS/X","RSX"},
                {"RS/Y","RSY"},
            };
        }

        public string GetSpriteName(string displayName)
        {
            if (_keyCharacterMappings.TryGetValue(displayName, out var spriteName))
                return spriteName;

            // Fallback
            return displayName;
        }
    }
}