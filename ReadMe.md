### Try On Shirt
Try on Shirt allows users to try out shirts in an augmented environment. This will help user's decide if the apparel is right for them and visualize wearing this apparel more easily. We are submitting this as part of the DubHacks Hackathon 2020. Our team believe that the epidemic in 2020 creates a lot of problem that technology can solve. One of them being the boundaries of the virtual world in e-commerce. It has always been hard for people to visualize what they're buying and our team hope that this project can help bridge the disconnect between virtual and reality.

## Try it Out!
We are using ARKit's Human Body Tracking so this project can only run with IOS Devices that have A12 Bionic Chip or above. This project also require MacOs device to compile the IOS app and Unity to compile the Unity project.

Requirement:
- XCode
- Unity 2020.1 or above
- IOS Device with A12 or above (IPhone XS or newer)

Steps
1. Clone this repository
2. Open the folder 'AR-TryOnShirt' as a Unity Project
3. Configure Build Settings:
    - Change build target to IOS
    - Add the scenes 'Main', 'Main1', 'Menu' to Scenes to Build
4. Configure Project Settings:
    - Put a description on Player->IOS->Other Settings-> Camera Usage Description
    - Allow XR Plug-in Management->Plug-in Providers->ARKit
5. Build & Run

Unity will automatically open XCode

6. Sign &
7. Plug in your IOS device & compile!

If you run at some technical issue, feel free to email
vincent.sastra@gmail.com or open a GitHub issue
