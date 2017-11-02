# HoloLens-LookInput-sample

target environment
* [Unity 2017.2.0f3](https://unity3d.com/kr/unity/whats-new/unity-2017.2.0)
* [MixedRealityToolkit-Unity for Unity 2017.1.2](https://github.com/Microsoft/MixedRealityToolkit-Unity/releases/tag/v1.2017.2.0)

In above environment, unity's HoloLensInputModule omit some click event.

**MixedRealityToolkit's InputManager + Unity's HoloLensInputModule**

![HoloLensInputModule](https://raw.githubusercontent.com/if1live/HoloLens-LookInput-sample/master/document/basic-input.gif)


So, I use custom InputModule, based on [LookInputModule][ref-look-input-module]

**MixedRealityToolkit's InputManager + MyHoloLensInputModule**

![MyHoloLensInputModule](https://raw.githubusercontent.com/if1live/HoloLens-LookInput-sample/master/document/custom-input.gif)

## Usage
1. import MixedRealityToolkit
2. copy `MyHoloLensInputModule.cs` into target project
3. add `MyHoloLensInputModule` into MixedRealityToolkit's `InputManager/EventSystem`

## Reference
* [LookInputModule][ref-look-input-module]

[ref-look-input-module]: https://forums.oculus.com/developer/discussion/16710/new-unity-ui-ovr-look-based-input-howto
