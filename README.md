<h1 align="center">Button Icon Resource Manager</h1>
<p align="center">
<a href="https://openupm.com/packages/com.studio23.ss2.buttoniconresourcemanager/"><img src="https://img.shields.io/npm/v/com.studio23.ss2.buttoniconresourcemanager?label=openupm&amp;registry_uri=https://package.openupm.com" /></a>
</p>

Button Icon Resource Manager is a Unity library that simplifies the management of button icons for Xbox and Playstation controllers. It uses the ControlPath formatting that the Unity Input System uses for seamless integration. It will continue to function as expected even after you rebind your original controls!

## Table of Contents

1. [Installation](#installation)
2. [Usage](#usage)
    - [Setting up Icon Assets](#settings-up-icon-assets)
    - [Using KeyIconManager](#using-keyiconmanager)
3. [License](#license)

## Installation

### Install via Git URL

You can also use the "Install from Git URL" option from Unity Package Manager to install the package.
```
https://github.com/Studio-23-xyz/ButtonIconResourceManager.git#upm
```

## Usage

### Setting up Icon Assets

The package comes with scriptable objects set for the 19 default buttons for Xbox and Playstation controller. If you want to use different icons or want to regenerate the assets yourself, you can follow the steps below to do so. 

Ensure that you have the necessary folder structure in your project's `Resources` folder for storing key icons. You should have folders named `PS` and `Xbox` containing your key icon assets (e.g., `.png` or `.asset` files). The hierarchy should look like this, 

`Assets\Resources\ButtonIcons\Xbox\` & `Assets\Resources\ButtonIcons\PS\`

Now you need to create the Assets that will hold the key-control path name and the icons related to it. To do so, find the Studio-23 tab on the top bar and go to, 
`Studio-23 > Button Icon Resource Manager > Create ButtonIcon Objects` 
This will generate icon holder assets for all the icon sprites found in the Resources directory. You can see these scriptable objects inside `Assets\Resources\KeyIcons` folder.

### Using KeyIconManager

1. **Accessing Key Icon Manager**:

   You don't have to attach the KeyIconManager to any gameobject as it will be self-instantiated when called upon. Simply call `KeyIconManager.Instance` to use the functionalities. 

2. **Retrieve Button Icons**:

   Use the `GetIcon` method from the `KeyIconManager` to retrieve button icons based on the platform and control path. Pass the platform name and control path as parameters. The function has two signatures, 

   ```csharp
    public Sprite GetIcon(Platform platformName, Buttons button)

    public Sprite GetIcon(string platformName, string controlPath)
   ```

Both functions can be interchangeably however the it depends on how you are using the input system. As Unity Input System innately has a function `InputAction.GetBindingDisplayString` which has an override which returns the `deviceLayoutName` and the `controlPath` for the targeted `InputAction`. Using this function is helpful if you are providing rebinding feature in the game as the binding display string will be dynamically updated when binding overrides are there. 

   An example usage scenario is given below. 

   ```csharp
   using UnityEngine;

   public class ExampleUsage : MonoBehaviour
   {
       void Start()
       {
           // Replace "Platform.PLAYSTATION" and "Buttons.BUTTON_SOUTH" with your platform and control path.
           Sprite buttonIcon = KeyIconManager.Instance.GetIcon(Platform.PLAYSTATION, Buttons.BUTTON_SOUTH);
           if (buttonIcon != null)
           {
               // Use the buttonIcon as needed.
           }

           Sprite buttonIconStringBased = KeyIconManager.Instance.GetIcon(deviceLayout, controlPath); //deviceLayout & controlPath are string variables.
           if (buttonIconStringBased != null)
           {
               // Use the buttonIconStringBased as needed.
           }
       }
   }
   ```

`deviceLayout` parameter is versatile and can be either the control scheme name you set in InputActionAsset or the Device Layout name (ie. `XInputController`, `DualShockGamepad`). 

You can take a peek at the Buttons enums as well as the control path strings for controller buttons from [here](https://github.com/Studio-23-xyz/ButtonIconResourceManager/blob/upm/Runtime/Data/Mappings.cs). Alternatively, you can also get the control paths for a particular binding from the `InputActionAsset` interface. 

## Icons Reference

The icons used in the sample are taken from [Controller Icon Pack](https://assetstore.unity.com/packages/2d/gui/icons/controller-icon-pack-128505) created by [NullSave](https://assetstore.unity.com/publishers/35534)