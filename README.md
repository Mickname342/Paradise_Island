# Game_Engines_Project

## YouTube video:
[Link to the video](https://www.youtube.com/watch?v=Es6QX_h6WTI)

## Research

## Ducks
To study the ducks, I went to phoenix park and I took a couple of pictures and some videos.

![Duck1](https://github.com/Mickname342/Game_Engines_Project/blob/main/Images/20240428_161914.jpg)
![Duck2](https://github.com/Mickname342/Game_Engines_Project/blob/main/Images/20240428_162310.jpg)

(the videos can be found in the folder called Duck Videos)
After studying them for a while I found that they had 5 different behaviours:
-	Stay: This state is when the ducks are on land and they sit and stay still. This behaviour is exclusive to when they are on land because they would not stay still while on water.
-	Go to water: This behaviour is for when they are walking on land in the direction of water with the intention of going into it.
-	Wander water: This state is for when the duck is already on water and it starts to wander.
-	Go to land: This behaviour is for when the duck is on water and goes in the direction of land with the intention of getting out of the water.
-	Wander Land: This state is for when the duck is on land and t walks in a random direction.
They seemed to switch between these states at random while they were either on land or water, So I ended up making this flow-chart:

![FlowChart](https://github.com/Mickname342/Game_Engines_Project/blob/main/Images/20240504_233220.jpg)
 
To simulate the duck in unity I used 2 behaviours: Seek and Wander Noise. They were implemented in the following ways:
-	Stay: The seek behaviour and noise wander behaviours weight is 0 and the target object for seek is set to null
-	Go to water: The wander noise has a weight of 0 and seek a weight of 1. The target object would be 1 of 4 objects placed on the water and it is set to be the nearest one to the duck at the moment of the switch.
-	Wander water: Wander noise weight is set to 7 and seek weight is set to 1. The target object is set to whatever the previous target object was in the “Go to water” state.
-	Go to land: The wander noise has a weight of 0 and seek a weight of 1. The target object is the centre of the island.
-	Wander land: Wander noise weight is set to 7 and seek weight is set to 1. The target object is the centre of the island.
With these behaviours and the flowchart I was able to implement the behaviour of ducks very similarly to real life. The main differences are that they don’t switch behaviours as frequently (which I kept for the sake of having a better viewing experience), that they always go to a specific point in the water instead of a random spot and finally that they don’t go in pairs. While studying they would very rarely move in pairs while on the water, but it was so rare that I decided to not implement it (although it sometimes looks like it is implemented).
The duck ended up being the most complex boid in the simulation.

