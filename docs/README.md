# FluxQuest Design Documents.

This is the start of a real design document for this project. It is also an experiment, to see if placing the documentation in this location is useful. I have named this file README.md to simplify viewing the design docs through github.

I am currently having issues getting GitHub to allow me to upgrade to premium, but once that is worked out, I will set up the wiki instead.

### Table of Contents
1. [Discussion](#Discussion)
2. [Elements](#Elements)
3. [Class World](./ClassWorld.md)


## Discussion

FluxQuest, possibly to be renamed Seeds of Mana, is an RPG that mixes an unusual sort of world building with procedural elements. This makes it fall into the RogueLite category. How much it deviates from that category is yet to be seen.

When the world first spawns, the player will find themselves in a small void. They find a book and a magical sphere. The book gets them started on their journey and the sphere is a tool that helps them control their new world.

The book is a guide book that will grow and gain information as their world grows. Once they are able to open their inventory they will find a few days rations, bedding, a few tools, and a few "Mana Seeds" that they will use to start building their world.

As they build their realm, they will become stronger and gain access to more skills and abilities.

As their world grows, dungeons will spawn that let them gain resources, as well as gaining temporary access to other worlds.

The world will be built up of tiles and plots. New tiles are created by planting "seeds" that cause properties to spread out from the central point to the tiles around them.  When new seeds are planted they can influence tiles that are already in place.

As seeds are planted nearer the edges of the realm, the pocket dimension itself will grow to give more space to move, build, and plant seeds.

## Elements
These are the various elements discussed above so far. They don't necessarily have to be implemented in this order. For now, I am organizing thoughts, and breaking it down into things that need to be implemented.

- Starts in a small void. A book and sphere are there. The player needs to interact with the book.
- The player cannot walk past the boundaries of the void.
- The player needs to be able to pick up the sphere and activate it, and interact with it.
- The book tells the player to open their inventory and put the items in it. They need an inventory.
- The player needs to be able to access the book from the inventory.
- The player needs to be able to access the sphere from the inventory.
- The player needs to be able to access their status screen.
- The player needs to be able to plant the seeds.
- The player needs to be able to place the bedding, and pick it up again.
- Time needs to pass in some form.
- The player needs food.
- The player needs air.
- The player needs sleep.
- The player needs to be able to improve stats.
- 