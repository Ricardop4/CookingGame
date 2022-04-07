# Cooking Craze - Wednesday, April 6 - Ricardo Puno

## Game Purpose and Function
The purpose of this game was to create a fun collecting game with food. Combined with the aspects of crafting, a cooking game emerged.
It includes a 5-slot inventory system, crafting system and scoring system. Implementing a recipe system was quite challenging. Instead of a recipe system, the code now just counts if the number of ingredients in your inventory. If there is at least 3 ingredients, you are able to cook a random food item for a set list. When cooking, all of your ingredients will be used. A score is kept in order to establish a sense of accomplishment. Each recipe will yield a different food item that will be worth much more than the ingredients, which have 15 points. 

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

### If you fell behind schedule, why? What would you do differently next time?
Day 1 and 2 were going smoothly, I was able to look for assets and assemble a rough UI for the Foraging Scene. I started to figure out the inventory system, by doing research and looking around for ideas on the internet. I stumbled upon a video that would complement my program's design. 
On Day 3, the inventory system was going smoothly and I started the Recipe system. 
Day 4 proved that the Recipe system was too complex. After thinking about I came up with the Random Recipe system instead.
Day 5 and 6 were the finishing touches, such as score, design and sound effects!
I should've planned for something more simple, following a modular system, so that I could edit it little by little.

### What problems did you run into that surprised you and how did you overcome them?
At one point, when figuring out how to spawn ingredients in, I accidentally created an infinite loop of spawning one item in. Crashed Unity. Lost some work in the process, but luckily it was very minor. Turns out, I had not reset the counter back to 0, since the code finds Game Objects with the tag "item".
When trying to figure out the recipe system, I decided to go with something simpler. I had difficulty figuring out how to find the Game Objects in the inventory, so I added a script to it that would allow me to delete it. I spend about 1 hour figuring that out, but I was so relived to be able to implement a crafting system.

### If you were doing it this app all over again, what do you wish you knew that you didn't?

### Anything else that you'd like your teacher to know and something you'd like to explain that might help you earn back grades?
