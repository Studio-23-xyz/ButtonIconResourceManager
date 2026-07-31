using Studio23.SS2.ButtonIconResourceManager.core;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class Main : MonoBehaviour
{
    private UIDocument _document;
    private VisualElement _rootElement;
    private Label _label;
    private Label _label2;

    private const string LabelText = "Hello There  <sprite name=\"{ICON}\">";
    private const string LabelText2 = "<sprite name=\"{ICON2}\"> says hi";
    private string _bindingDisplayName;
    
    [Header("Input")]
    [SerializeField] private InputActionReference inputActionReference;
    
    [Header("Panel Settings")]
    [SerializeField] private PanelSettings keyBoardPanelSettings;
    [SerializeField] private PanelSettings gamePadPanelSettings;

    private void OnEnable()
    {
        _document = GetComponent<UIDocument>();
        _rootElement = _document.rootVisualElement;
        _label = _rootElement.Q<Label>("label");
        _label2 = _rootElement.Q<Label>("label2");
    }

    private void Start()
    {
        ShowUI();
    }
    
    private void ShowUI()
    {
        if (Gamepad.all.Count > 0)
        {
            _document.panelSettings = gamePadPanelSettings;

            _bindingDisplayName = inputActionReference.action.GetBindingDisplayString(1);
            _bindingDisplayName = KeyIconManager.Instance.GetSpriteName(_bindingDisplayName);
        }
        else
        {
            _document.panelSettings = keyBoardPanelSettings;

            _bindingDisplayName = inputActionReference.action.GetBindingDisplayString(0);
            _bindingDisplayName = KeyIconManager.Instance.GetSpriteName(_bindingDisplayName);
        }

        _label.text = LabelText.Replace("{ICON}", _bindingDisplayName);
        _label2.text = LabelText2.Replace("{ICON2}", "b");
    }
}
