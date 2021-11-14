# DEV-14, Creating Sparks
#### Tags: [creating]

## Set up

    Be sure to update the Backdrop to standard. Seems to be slightly broken on arrival in recent versions.

![](../images/DEV-14/DEV-14-A.png)

    To build a visual effect in unity, first create an empty game object 

![](../images/DEV-14/DEV-14-B.png)

    Be sure to reset its position in the world space, resetting the transform

![](../images/DEV-14/DEV-14-C.png)


## Naming conventions

    Be organized, Don't leave textures, materials and effects unnamed
    
    Example:
    
    vfx_<Name>_<Additional Features>
    Actual:
    vfx_Sparks_Loop

## Adding prefabs

![](../images/DEV-14/DEV-14-D.png)


## Creating Particles

![](../images/DEV-14/DEV-14-E.png)

![](../images/DEV-14/DEV-14-F.png)

If for some reason its pink/magenta squares then the material is not rendering correctly on the particles. You can see that you can apply a default material for the time being.

## NOTE: Review on old projects

https://github.com/MuteBard/BlockBreaker
https://github.com/MuteBard/LaserDefender
https://github.com/MuteBard/ObstacleCourse
https://github.com/MuteBard/ProjectBoost
