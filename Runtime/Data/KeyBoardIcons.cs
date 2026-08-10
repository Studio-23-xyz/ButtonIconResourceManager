
using UnityEngine;

namespace Studio23.SS2.ButtonIconResourceManager.Data
{
    [CreateAssetMenu(fileName = "KeyIcons-{KeyName}", menuName = "Studio-23/Button Icon Resource Manager/KeyBoard Icons")]
    public class KeyBoardIcons : ScriptableObject
    {
        [SerializeField]
        private Sprite _keyBoardIcon;
        public string ControlPath;

        public void Initialize(Sprite keyBoardIcon, string controlPath)
        {
            _keyBoardIcon = keyBoardIcon;
            if (controlPath.Contains("-"))
                controlPath = controlPath.Replace("-", "/");
            ControlPath = controlPath;
        }


        public Sprite GetIcon()
        {
            return _keyBoardIcon;
        }
    }
}

