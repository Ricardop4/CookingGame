# Cooking Craze - Wednesday, April 6 - Ricardo Puno

## Game Purpose and Function
The purpose of this game was to create a fun collecting game with food. Combined with the aspects of crafting, a cooking game emerged.
It includes a 5-slot inventory system, crafting system and scoring system. Implementing a recipe system was quite challenging. Instead of a recipe system, the code now just counts the number of ingredients in your inventory. If there is at least 3 ingredients, you are able to cook a random food item from a list. When cooking, all of your ingredients will be used. A score is kept in order to establish a sense of accomplishment. Each recipe will yield a different food item that will be worth much more than the ingredients, which have 15 points. 

## Known Issues or Problems
When dropping food items near the top, they will spawn just north of the player, therefore, out of reach and out of sight. 

## Future Enhancements
Add more food items
Food power ups, such as increasing grab length or speed.
Different character designs
Definitely a proper recipe system. If I can code to count how many items are in my inventory, I can code to figure out what items are in the inventory and craft a certain recipe.

## Other Notes
Game is best played in Standalone screen size from the default layout of Unity.
Use arrow keys or WASD keys to move around.
Items in inventory, crosses and the cooking button are clickable.

## Self-Evaluation
### What went wrong and how would you do it differently next time?
I had so much difficulty figuring out how to make a recipe system, I ended up just making it so that the program would find out how many items you currently have in your inventory and would allow you to create a random food item if so. 
When figuring out how to spawn items, I wanted something to spawn every 5ish minutes, so I researched how to make the program wait. From my findings, the looping was hard to figure out and it would only spawn one item, once. Instead, I replaced it so that it would spawn items, if the number of items was <=9

### If you fell behind schedule, why? What would you do differently next time?
Day 1 and 2 were going smoothly, I was able to look for assets and assemble a rough UI for the Foraging Scene. I started to figure out how the inventory system would work, but I mainly focused on getting player movement. I found a video that would show how to create top down movement in Unity and followed along. 
After completing player movement, I went to the inventory system and found another video that would compliment the style of my cooking game.
On Day 3, the inventory system was going smoothly and I started the Recipe system. 
Day 4 proved that the Recipe system was too complex. After thinking about I came up with the Random Recipe system instead. I also decided to somewhat merge the Foraging Scene and the Cooking Scene together by allowing the player to cook in the Foraging Scene.
Day 5 and 6 were the finishing touches, such as score, design and sound effects!
I should've planned for something more simple, following a modular system, so that I could edit it little by little. For example, I wanted to create a recipe system, I should've figured out how to collect items first, use the items in the inventory and actually craft it for the player to interact with. Taking a simpler approach would've helped smooth out the process.

### What problems did you run into that surprised you and how did you overcome them?
At one point, when figuring out how to spawn ingredients in, I accidentally created an infinite loop of spawning one item in. Crashed Unity. Lost some work in the process, but luckily it was very minor. Turns out, I had not tagged the game object as "item", since the code only spawns if the number of game objects with the tag "item" was <= 9.
When trying to figure out the recipe system, I decided to go with something simpler. The Random Recipe System.
I had difficulty figuring out how to find the Game Objects in the inventory, so I added a script to it that would allow me to delete it. I spend about 1 hour figuring that out, but I was so relived to be able to implement a crafting system.
I was trying to figure out how to give all the food items different points when they were eaten. I used the method from the previous Block Breaker game, AddToScore(); that would allow me to add to the score and modified it to match the cooking game. It then hit me; I could use an argument that would take the points of a unique food item and run it though the method AddToScore(int foodPoints);

### If you were doing it this app all over again, what do you wish you knew that you didn't?
If I were to redo this app all over again, I wish I knew how to figure out what items were in the inventory and compare it to the recipes I had and make a unique food item. Instead of generating a random food item everytime the Cooking Time button was pressed. Although, this mechanic fits in with the name "Cooking Craze".

### Anything else that you'd like your teacher to know and something you'd like to explain that might help you earn back grades?

