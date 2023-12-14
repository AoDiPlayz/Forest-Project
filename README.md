# The Forest Project
Our project aims to address issues in animal captivity by offering a VR simulation that provides an alternative to viewing animals in zoos and animal confinement institutions without having to encage them. This simulation offers detailed insights about the animals, reducing the need for their captivity for entertainment and education. keeping animals away from their natural environment puts stress and long-term issues on them, potentially leading to their extinction. Our VR project is important as it completely removes the need for real life animals to be held in captivity for the entertainment and education to be maintained. 
### What are it's features?
Our VR simulation offers a jungle environment with interactive animals and pop-ups containing information on the animal. It's ideal for schools, museums, and areas with limited access to nature, providing an immersive educational experience. While targeted towards young children, adults can also enjoy this engaging VR environment as it is not only educational but also entertaining.
### Implementation
For this project, we have implemented a jungle environment where the background and the setting strongly represents the natural environment of a wild animal. We have also implemented audio to further represent a jungle. We have added a wolf into the environment where the wolf moves around as it would it do naturally in its habitat. We have also added popups upon interaction with our UI where the popups include educational information on the animal.
### Problems and Challenges when creating our Project
- Issues with the Environment \
  When we first imported our Environment, the camera was located at the corner of the environment and sunk into the environment. As we were very new to Unity we had to learn how to move the game camera towards the center of our Environement.
- Issues with the Nav Mesh Agent and Nav Mesh Surface \
  When trying to implement our AI Navigation we encountered many issues. Our first issue was with the trees in the environment not being recognized by the Nav Nesh Surface and thus the Wolf would walk through it. We had to re do the terrain such that each tree was a seperate object, rather than part of the terrain and added capsule colliders around each tree so that the Nav Mesh Surface would recognize the trees as objects that the Nav Mesh Agent cannot travel through. However after adding the Capsule Collider, another issue we faced was that the wolf would walk above the trees and when walkign near the trees the wolf would teleport up and down as if glitching. We had to tweak the parameters of the Nav Mesh Surface and the Nav Mesh Agent, such as the step height, incline, radious and etc. When the wolf was no longer walking on the trees, it began to teleport below the ground in about 5 second intervals. We had to lower the terrain and raise the wolf such that the wolf only walked on the terrain rather than below it.
- Issues with the Animator \
  Our first issue with the Animator was that the Animator would not alternate between all the states and only alternated between walk and creep. We had to edit our functuon _setRandomState()_ such that our script would recognize the other states. After fixing that issue we realised that our wolf would move at the same speed no matter what state it was in. For example when the wolf transitioneed to the sit state, the wolf would still be moving and so it looked extremely unnatural. Thus we added into our code _Agent Speed_ and made it such that the speed of the Nav Mesh Agent would be different based on the Animation State of the wolf.
- Issues with VR Implementation \
  One of the major challenges when creating our project was when Unity would not recognize our VR headset. We found out that Unity was blocked on regular headsets and that we would need to activate Developer Mode. Another challenge we faced was with movement because while the movement axis was fixed, the orientation of our vision was not and so moving around the simulation proved teo be quite tricky. We were unable to solve this issue and worked around it by learning to navigate based on memorizing the axis of movement.
### What would we do Differently the next time
- Impelmeenting more Animals \
  As we already know the correct parameters for the Nav Mesh Agent we could copy these parameters for another Animal. The Nav Mesh Surface is already set up and so there would not be much work to implement another Animals AI movement. The issue that prevented us from implementing anither aninak was not finding a suitable prefab online that already contained animation states and would work wtih our script. Next time if unable to find other animal pre fabs I would implement stationary Animals in the background to create a more realistic space.
- Interaction with the Animals \
Currrently our simualtion does not have any interaction with the animals. To make the simulation more engaging for users we could implement actions such as feeding or playing catch that would increase engagement and improve the entertainment and educational value of the simulation.
- VR Movement \
Another thing we would do would be to edit the movement such that that the movement axis is based on the direction the VR headset is facing.
## User Manual
- When first booting up \
Ensure that your VR headset has enbaled devleloper mode. If not go on your unity account and enable developer mode for the headset. Ensure that your Unity has Android SBK installed and all the files necessary for VR implementation. Connect the headset to your device and go into build setting and select your VR headset as the device to run on. The build and run.
- Once in the simulation \
You will begin the simulation in the center of the environment. In front of you is a button that if pressed will make an information panel that tells you about the American Red Wolf appear. Next to the information panel will be a model of the American Red Wolf that you can walk around to inspect. While you do this, an American Red Wolf will be exploring the environment around you. You will get the chance to observe what an American Red Wolf is like in the wild rather than in a zoo. The wolf will walk around. It will run when it wants and sit when it wants. You will also be able to walk up to the wolf to observe it up close and personal. Once done observing you can press the button to make the popups disappear and when you wish to exit, go into the menu of the VR headset to exit the simulation.
## Contributions
- Andre Llenata: Wolf Code, Popups upon Interaction
- Laial Saad: Jungle Environment, Wolf Asset, Skybox
- Zuhair Abdelmutalab: Popups upon Interaction, Audio
- Sanad Madi: Jungle Envrionment

### THANK YOU FOR EXPLORING OUR PROJECT
