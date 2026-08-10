using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace Studio23.SS2.ButtonIconResourceManager.Editor
{
    public class ButtonIconGeneratorUIToolkit : EditorWindow
    {
        [MenuItem("Studio-23/Button Icon Resource Manager/Create Sprite Asset for UI toolkit")]
        public static void CreateButtonIconSpriteAssets()
        {
            SpriteAsset keyBoardSpriteAsset = Resources.Load<SpriteAsset>("SpriteAssets/KeyBoard/KeyBoard");

            SpriteAsset gamepadSpriteAsset = Resources.Load<SpriteAsset>("SpriteAssets/GamePad/GamePad");

            if (Directory.Exists($"Assets/Resources/KeyIcons/SpriteAssets/"))
            {
                Directory.Delete($"Assets/Resources/KeyIcons/SpriteAssets/", true);
            }

            Directory.CreateDirectory($"Assets/Resources/KeyIcons/SpriteAssets/GamePad");
            Directory.CreateDirectory($"Assets/Resources/KeyIcons/SpriteAssets/KeyBoard");

            if (keyBoardSpriteAsset != null)
            {
                CreateSpriteAsset(keyBoardSpriteAsset, $"Assets/Resources/KeyIcons/SpriteAssets/KeyBoard/KeyBoard.asset");
            }

            if (gamepadSpriteAsset != null)
            {
                CreateSpriteAsset(gamepadSpriteAsset, $"Assets/Resources/KeyIcons/SpriteAssets/GamePad/GamePad.asset");
            }

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private static void CreateSpriteAsset(SpriteAsset original, string destinationPath)
        {
            SpriteAsset copy = Instantiate(original);

            AssetDatabase.CreateAsset(copy, destinationPath);
        }
    }
}