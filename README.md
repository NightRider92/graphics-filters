This is an example implementation of graphics filters in .NET / C#

I am aware that using of image.SetPixels() is not a good choice for larger pictures (performance, etc ...) and LockBits() should be used but like I said, it's just an example project.

Original image

![image](https://github.com/NightRider92/graphics-filters/assets/10942663/5fcb77de-ffcc-4a1c-853e-fb3ff83c4fc0)

Fisheye filter

Fisheye is being calculated by equisolid angle projection formula which means we are converting 2D cartesian coordinates to polar coordinates

![image](https://github.com/NightRider92/graphics-filters/assets/10942663/ba07ea7a-9b20-4a4b-b3d1-193ce514894e)

Binary threshold

![image](https://github.com/NightRider92/graphics-filters/assets/10942663/5f250681-8985-4e51-a4ed-453f3dd4514d)

Color inversion

![image](https://github.com/NightRider92/graphics-filters/assets/10942663/8774f3a4-1164-4445-a113-f651cb0783a

All 3 filters applied

Fisheye
Binary threshold
Color inversion of binary threshold

![image](https://github.com/NightRider92/graphics-filters/assets/10942663/198b6369-bfc1-4496-b152-50cd84f3066d)
