# <img src="WinFormAnimation_NET5/Icon.png" width="42" alt="Icon"> WinForm Animation Library [NET5]
[![GitHub](https://img.shields.io/github/license/crytilis/WinFormAnimation_NET5)](https://github.com/Crytilis/WinFormAnimation_NET5/blob/master/LICENSE.md)
[![GitHub issues](https://img.shields.io/github/issues/crytilis/WinFormAnimation_NET5)](https://github.com/Crytilis/WinFormAnimation_NET5/issues)

A simple library for animating controls and values in Windows Form projects. WinFormAnimation_NET5 is Key frame (Path) based and fully customizable. 
*Original .NET Framework project was created by Soroush Falahati*

*Please note that even though this library designed for WinForm but its usage is not limited to WinForm and can be used in other environments. Only reference of the library is to 'System.Drawing' name space.*

## How to get
[![Nuget](https://img.shields.io/nuget/dt/WinFormAnimation-NET5?color=blue)](https://www.nuget.org/packages/WinFormAnimation-NET5)
[![Nuget](https://img.shields.io/nuget/v/WinFormAnimation-NET5)](https://www.nuget.org/packages/WinFormAnimation-NET5)

This library is available as a NuGet package at [nuget.org](https://www.nuget.org/packages/WinFormAnimation_NET5/).

## Want to help Improve?
You can always donate your time by contributing to the project or by introducing it to others..

## Documentation

* `Float2D`: A class containing two `float` values as Vertical and Horizontal coordinates representing a point in a 2D plane.
* `Float3D`: A class containing three `float` values as Vertical, Horizontal and Depth coordinates representing a point in a 3D plane.
* `Path`: A class containing a `float` starting and a `float` ending point for a single dimensional animation as well as duration and the function to control the animation.
* `Path2D`: A class containing a `Float2D` starting and a `Float2D` ending point for a two dimensional animation as well as duration and the function to control the animation.
* `Path3D`: A class containing a `Float3D` starting and a `Float3D` ending point for a three dimensional animation as well as duration and the function to control the animation.
* `Animator`: A class for animating an array of `Path` objects. This class is one of the main classes and starting points of a basic animation.
* `Animator2D`: A class for animating an array of `Path2D` objects. This class is one of the main classes and starting points of a basic animation.
* `Animator2D`: A class for animating an array of `Path3D` objects. This class is one of the main classes and starting points of a basic animation.
* `SafeInvoker`: A class holding a reference to a function to invoke in the correct thread, detected by a `Control` object passed to it. Useful for easier UI manipulations.
* `SafeInvoker<T>`: Same as `SafeInvoker` class but with a generic argument for the function to invoke.

## Basic examples
### ONE DIMENSIONAL ANIMATION OF A PROPERTY
Following code animates a property named `Value` of a `ProgressBar` named `pb_progress` in 5 seconds from zero to one hundred:
```C#
new Animator(new Path(0, 100, 5000))
    .Play(pb_progress, Animator.KnownProperties.Value);
```

### TWO DIMENSIONAL ANIMATION OF A PROPERTY
Following code animates a `Form` in two paths. First one moves the `Form` from (0, -100) to (100, 200) and second path waits for 3 seconds and then moved the `Form` to its initial location in 2 seconds. (`this` is a `Form`)
```C#
new Animator2D(
        new Path2D(0, 100, -100, 200, 5000).ContinueTo(this.Location.ToFloat2D(), 2000, 3000))
    .Play(this, Animator2D.KnownProperties.Location);
```

### THREE DIMENSIONAL ANIMATION OF A PROPERTY
Following code animates a property named `CustomColor` of a `Control` named `c_customLabel` in 2 seconds and after a delay of 1 second using the `AnimationFunctions.CubicEaseIn` function and with maximum of 10 frames per second.
```C#
new Animator3D(
        new Path3D(Color.Blue.ToFloat3D(), Color.Red.ToFloat3D(), 2000, 1000, AnimationFunctions.CubicEaseIn), 
        FPSLimiterKnownValues.LimitTen)
    .Play(c_customLabel, "CustomColor");
```


### KEYFRAMES
There are extension methods for `Path`, `Path2D`, `Path3D` and their arrays to let you continue the path easily and define the key frames as fast as possible. For example, following code moves a `Control` named `c_control` in a rectangular path infinitely:
```C#
new Animator2D(
    new Path2D(new Float2D(100, 100), new Float2D(200, 100), 1000)
        .ContinueTo(new Float2D(200, 200), 1000)
        .ContinueTo(new Float2D(100, 200), 1000)
        .ContinueTo(new Float2D(100, 100), 1000))
{
    Repeat = true
}.Play(c_control, Animator2D.KnownProperties.Location);
```

### CALLBACKS
It is possible to define a custom callback as frame handler as well as defining a call back to handle the end of the animation. Following example will call a method named `CustomSetMethod` for setting new values and handle the frames, and starts the animation in reverse path after its end for one more time:

```C#
var animator = new Animator(new Path(100, 200, 1000).ContinueTo(400, 500));
animator.Play(new SafeInvoker<float>(CustomSetMethod), new SafeInvoker(() =>
{
    animator.Paths = animator.Paths.Select(path => path.Reverse()).Reverse().ToArray();
    animator.Play(new SafeInvoker<float>(CustomSetMethod));
}));
```

## Demo
Check the 'WinFormAnimation_NET5.Samples' project for simple usage examples.
![Screenshot](/screenshot.gif?raw=true "Screenshot")

## License
The MIT License (MIT)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
