# Game_Engines_Project

## YouTube video:
[Link to the video](https://www.youtube.com/watch?v=Es6QX_h6WTI)

## Research
If you prefere there is pdf file with the exact same text for you to read. If you prefer to read the readme keep reading, if not go to the documentation folder.

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

## Whale:
The whale was the second boid I implemented.
The first thing I did for the whale was code the tail and fin movement. The whale, unlike other aquatic animals, moves its tail up and down because it is a mammal and their bones naturally blend up and down. Information taken from the whale and dolphin conservation centre:

[Link to a video](https://uk.whales.org/whales-dolphins/why-do-whale-and-dolphin-tails-go-up-and-down/#:~:text=Unlike%20fish%2C%20whales%20and%20dolphins,for%20propulsion%20through%20the%20water)

To replicate this, I created a sin wave movement code that would take an array of transforms and would move them up and down depending on the time, an amplitude, an angle, a frequency ad their position on the array. This recreated the movement perfectly. As for the fins the rotate on all of their axis depending on a sin wave as well.

The majority of recorded movement of whales is recorded on a large scale, partially due to their size, it has been studied that whales will travel to warmer waters for skin maintenance.

[See this link](https://www.fisheries.noaa.gov/feature-story/why-do-whales-migrate-they-return-tropics-shed-their-skin-scientists-say#:~:text=%E2%80%9CInstead%20of%20whales%20migrating%20to,there%2C%E2%80%9D%20the%20scientists%20wrote)

After studying various videos, I noticed that they tend to wander in short distance travel.

[See this video](https://www.youtube.com/watch?v=Uvd2UYS8wVs )

Just making the whale wander with noise or jitter wander would be a problem due to its size, so instead I made it follow a path that circles around the island. But only follow a path would not feel natural so I created 2 states:

-	Follow path: In this state the whale will follow the path continuously without being interrupted. The follow path behaviour has a weight of 1 and the noise wander has a weight of 0.
-	Wander: In this state the whale will use a noise wander movement while also following the path.  The follow path behaviour has a weight of 1 and the noise wander has a weight of 2.

The follow path has a 40% chance to transition to the wander behaviour every 3 seconds. Meanwhile, the wander has a 60% to transitions to follow path every 3 seconds.

Comparing it to the real movement it is not as random because it follows a path, but it was necessary to make the simulation more concentrated. It was also impossible to replicate the long distance travel of whales for the same reason.

## Baby Whale:
The baby whale, as its name implies, is a boid that represents the offspring of the bigger whale. While they may share the same model with the only difference being its scale, their behaviours are very different.

Baby whales, [as seen in this video](https://www.youtube.com/watch?v=pJqlkuVKO2k), stay near their mother at all times and tend to wander a bit but not too far away from their mother.

To replicate this, I used 2 different behaviours: Pursue and Obstacle avoidance. For the pursue script the target is always set as the big whale and obstacle avoidance’s layers to avoid are set as the layer for the whale and the island.

It has 2 different states:

-	Purse: In this state it pursues the big whale constantly. The pursue weight is set to 4 and the avoidance weight is set to 0.
-	Avoidance: In this state it will avoid both the whale and the island constantly. The pursue weight is set to 0 and the avoidance weight is set to 17.

The baby whale will switch from the pursue state to the avoidance when either the whale or the island enter a sphere trigger that is around the game object. It will switch from the avoidance state to pursue once either the whale or the island exit the trigger.

This state machine was created for 2 reasons. The first one is to better control how close the baby whale can get to the big whale and the island and the second one is to prevent the baby whale from clipping into the model of the big whale, which was a bug that happened before implementing the state machine.

Comparing it to real life it is for the most part the same, the only thing I wasn’t able to replicate is the baby whale touching the big whale due to it clipping into the model and preferring bug prevention over behaviour fidelity.
