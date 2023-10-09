# Key Icon Manager

Key Icon Manager is a Unity library that simplifies the management of button icons for different platforms.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [License](#license)

## Installation

### Install via Git URL

You can also use the "Install from Git URL" option from Unity Package Manager to install the package.
```
https://github.com/Studio-23-xyz/ButtonIconResourceManager.git#upm
```

## Usage

Ensure that you have the necessary folder structure in your project's `Resources` folder for storing key icons. You should have folders named `Playstation` and `Xbox` containing your key icon assets (e.g., `.png` or `.asset` files).

Now you need to create the Assets that will hold the key-control path name and the icons related to it. To do so, find the Studio-23 tab on the top bar and go to, 
`Studio-23 > Button Icon Resource Manager > Create ButtonIcon Objects`

1. **Accessing Key Icon Manager**:

   You don't have to attach the KeyIconManager to any gameobject as it will be self-instantiated when called upon. Simply call `KeyIconManager.Instance` to use the functionalities. 

2. **Retrieve Button Icons**:

   Use the `GetIcon` method from the `KeyIconManager` to retrieve button icons based on the platform and control path. Pass the platform name and control path as parameters.

   ```csharp
   using UnityEngine;

   public class ExampleUsage : MonoBehaviour
   {
       void Start()
       {
           // Replace "PlayStation" and "Cross" with your platform and control path.
           Sprite buttonIcon = KeyIconManager.Instance.GetIcon("PlayStation", "buttonSouth");
           if (buttonIcon != null)
           {
               // Use the buttonIcon as needed.
           }
       }
   }
   ```

## License

The icons used in the sample are taken from [Free Prompts Pack v4.0](https://opengameart.org/content/free-keyboard-and-controllers-prompts-pack) created by, and made available to public domain by Nicolae Berbece.
Icons are licensed under [Creative Commons CC0](https://creativecommons.org/publicdomain/zero/1.0/).