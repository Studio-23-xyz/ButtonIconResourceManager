# Key Icon Manager

Key Icon Manager is a Unity library that simplifies the management of button icons for different platforms.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Example](#example)
- [Contributing](#contributing)
- [License](#license)

## Installation

### Install via Git URL
You can also use the "Install from Git URL" option from Unity Package Manager to install the package.
```
https://github.com/Studio-23-xyz/Better-Cursor-Manager.git#upm
```

## Usage

1. **Load Key Icons Manager**:

   Attach the `KeyIconManager` script to a GameObject in your scene or create an empty GameObject and add the script. This will make the manager accessible from your scripts.

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


 The icons used in the sample are taken from [Free Prompts Pack v4.0](https://opengameart.org/content/free-keyboard-and-controllers-prompts-pack) created by, and made available to public domain by Nicolae Berbece.
 Icons are licensed under [Creative Commons CC0](https://creativecommons.org/publicdomain/zero/1.0/).