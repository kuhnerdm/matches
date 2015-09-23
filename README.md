# matches
First-person puzzle game created in Unity engine

This repo contains the code for a first-person puzzle game created in Unity, tentatively titled "Matches". The main game mechanic revolves around limited light sources, currently consisting of only matches. The current state of the game is very simple, more of a proof-of-concept. So far I have created a simple test environment, coded first-person movement controls and primitive collision checking, and formed the basics of the light mechanics.

# Gameplay

The goal of the game is to reach the exit of each room. This is done by completing puzzles that require the player to see his/her surroundings. However, because the area is so dark, the player is forced to expend matches to catch a glimpse of the room's contents. Matches are limited, and extra ones can be picked up to replace spent ones.

# Scoring

Because a game like this is easy to become stuck in, there is be a simple way to restart the level, in which the player receives no penalty besides an addition to an "attempts" counter. This makes it easy to "cheat" your way through the game by restarting repeatedly and memorizing where everything is, but this ruins the experience and lowers the enjoyment value for the player, since he/she hasn't accomplished anything. So, in all fairness, the player shouldn't be doing this in the first place.