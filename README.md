# BlackGold
A RimWorld mod that adds oil gushers, pumpjacks and barrels to fill with oil.

##Changelog

###v0.2:

* Renamed pumpjack to derrick
* Added refinery that refines crude into oil (1 crude barrel, 6666 work)
* Added barrel of crude, made from barrel at derrick.
* Changed barrel of oil, now made from barrel of crude at refinery
* Barrels now used unfinished stage while filling and refining

###v0.1:

* Added oil gushers that generate just before steam geysers and with the same settings. Did so by modifying MapGenerators.xml which probably makes it incompatible with other mods that modify the same file. Uses steam geyser sprite but I created a custom mote and sprayer.
* Added barrel table. Has recipe to make barrels (10 steel, 1000 work). Uses machining table sprite.
* Added pumpjack that can (only) be placed on oil gushers. Has recipe to create an oil barrel (1 empty barrel, 6666 work - still not enough? Unsure about balance here). Uses placeholder sprite, would be fantastic if anybody threw a better one together.

##Planned

* Replace oil gushers with oil springs that do not produce oil and must be drilled first. Derricks will be used to drill and not to produce oil.
* Create pumpjack building that will be built offset to oil gushers and have an animated sprite and require power.
* Create plastics items and recipes.