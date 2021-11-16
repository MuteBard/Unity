# DEV-16, Making our spark
#### Tags: [bloom, particles]

    NOTE: This has failed, you cannot have both Universal RP and Post Processing, Universal RP comes with its own post processing and we gotta find out how to use it

## Adding Bloom Effect

    https://www.youtube.com/watch?v=c8hnKnXxGn8

    Go to the Windows > Package Manager and install Post Processing

![](../images/DEV-16/DEV-16-A.png)

    Add this component, post processing layer, to the Main Camera

![](../images/DEV-16/DEV-16-B.png)

    Add a new Layer, called Glow

![](../images/DEV-16/DEV-16-D.png)

![](../images/DEV-16/DEV-16-C.png)

    Add this component, post processing volume,  to our target object, Sparks

![](../images/DEV-16/DEV-16-E.png)

    Set all post processing effects to happen on layer "Glow"
    
![](../images/DEV-16/DEV-16-F.png)

![](../images/DEV-16/DEV-16-G.png)

    Create a post processing file

![](../images/DEV-16/DEV-16-H.png)

    Add newly created post processing file and adjust settings for post processing volume component

![](../images/DEV-16/DEV-16-I.png)