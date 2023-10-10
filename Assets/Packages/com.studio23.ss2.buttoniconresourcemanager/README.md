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

   Use the `GetIcon` method from the `KeyIconManager` to retrieve button icons based on the platform and control path. Pass the platform name and control path as parameters. The function signature is, 

   ```csharp
        public Sprite GetIcon(Platform platformName, Buttons button)
   ```

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
       }
   }
   ```

You can take a peek at the Buttons enums from [here](Runtime/Data/Mappings.cs)

## License

The icons used in the sample are taken from [Free Prompts Pack v4.0](https://opengameart.org/content/free-keyboard-and-controllers-prompts-pack) created by, and made available to public domain by Nicolae Berbece.
Icons are licensed under [Creative Commons CC0](https://creativecommons.org/publicdomain/zero/1.0/).