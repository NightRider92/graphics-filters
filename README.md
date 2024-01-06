This is an example implementation of graphics filters in .NET / C#

I am aware that using of image.SetPixels() is not a good choice for larger pictures (performance, etc ...) and LockBits() should be used but like I said, it's just an example project.

**Original image**

![image](https://github.com/NightRider92/graphics-filters/assets/10942663/5fcb77de-ffcc-4a1c-853e-fb3ff83c4fc0)

**Fisheye filter**

Fisheye is being calculated by equisolid angle projection formula which means we are converting 2D cartesian coordinates to polar coordinates

![image](https://github.com/NightRider92/graphics-filters/assets/10942663/ba07ea7a-9b20-4a4b-b3d1-193ce514894e)

**Binary threshold**

![image](https://github.com/NightRider92/graphics-filters/assets/10942663/5f250681-8985-4e51-a4ed-453f3dd4514d)

**Color inversion**

![image](https://github.com/NightRider92/graphics-filters/assets/10942663/1c09a01e-6f6a-4bac-90b8-4e37457b7f41)

**All 3 filters applied**

Fisheye
Binary threshold
Color inversion of binary threshold

![image](https://github.com/NightRider92/graphics-filters/assets/10942663/198b6369-bfc1-4496-b152-50cd84f3066d)
