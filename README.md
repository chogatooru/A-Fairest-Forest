# Game Project Overview

This project is a 3D game developed using the Unity engine, featuring the following core functionalities:

## Game Mechanics
- **Character Movement and Animation**: Logic for player and NPC movement along with animation state management.
- **Camera Following**: The game camera follows the player's movement to maintain the view.
- **Player Shooting**: Mechanics for player shooting, including bullet firing and effect display.
- **Enemy Behavior**: Patrol and attack behaviors of enemies in response to player actions.
- **Health System**: Health management system for both players and enemies, including injury and death animations.
- **Interaction System**: Player interactions with objects in the game world, such as collecting items and triggering events.
- **UI and Menus**: The game's user interface and menu systems, including the start menu, in-game menus, and end menus.
- **Level Loading**: Game level loading and transition effects.
- **Sound Management**: In-game sound playback, including ambient sounds and event-triggered sounds.
- **Particle Effects**: Particle effects in the game, such as shooting and explosion effects.

## Control Systems
- **Input Handling**: Processing player inputs from keyboards, mice, and game controllers.
- **Global Variable Management**: Managing game states and variables through a global variables class.

## Dialogue System
- **Dialogue Triggers**: Through `arrow.cs`, `NewDialogue.cs`, and `DialogueTigger.cs`, in-game dialogues can be triggered by player proximity to specific objects or mouse clicks.
- **Dialogue Manager**: `DialogueManager.cs` is responsible for managing the display and flow of dialogues, including displaying dialogue text and character names.
- **Yes/No Choices**: `YesOrNo.cs` handles branching choices in dialogues, allowing players to make decisions that affect the game's progress.
- **Dialogue Data Model**: `Dialogue.cs` defines a dialogue data model for easy management and storage of dialogue content.

## Cinematic Playback
- **Movie Texture Playback**: `REDcod.cs` and `EDcode.cs` are used for playing cinematic clips in the game to enhance storytelling and atmosphere.

## Game Flow Control
- **Timed Level Transitions**: `REDcod.cs` and `EDcode.cs` include timed transitions to the next game level after movie playback ends.

## UI Interaction
- **Click Interaction**: `NewDialogue.cs` and `DialogueTigger.cs` allow players to trigger dialogues through clicking UI elements, increasing the game's interactivity.

## Ending and Restart
- **Game Over Logic**: `EDcode.cs` contains a timer that automatically triggers game over logic and transitions to a specified level after a certain period following the end of movie playback.

This project demonstrates a complete game loop, including player control, enemy AI, interactions, and UI management. The goal of the game is to advance the plot through player interactions with the game world, while providing challenging enemies and collectible elements.# Game Project Overview

This project is a 3D game developed using the Unity engine, featuring the following core functionalities:

## Game Mechanics
- **Character Movement and Animation**: Logic for player and NPC movement along with animation state management.
- **Camera Following**: The game camera follows the player's movement to maintain the view.
- **Player Shooting**: Mechanics for player shooting, including bullet firing and effect display.
- **Enemy Behavior**: Patrol and attack behaviors of enemies in response to player actions.
- **Health System**: Health management system for both players and enemies, including injury and death animations.
- **Interaction System**: Player interactions with objects in the game world, such as collecting items and triggering events.
- **UI and Menus**: The game's user interface and menu systems, including the start menu, in-game menus, and end menus.
- **Level Loading**: Game level loading and transition effects.
- **Sound Management**: In-game sound playback, including ambient sounds and event-triggered sounds.
- **Particle Effects**: Particle effects in the game, such as shooting and explosion effects.

## Control Systems
- **Input Handling**: Processing player inputs from keyboards, mice, and game controllers.
- **Global Variable Management**: Managing game states and variables through a global variables class.

## Dialogue System
- **Dialogue Triggers**: Through `arrow.cs`, `NewDialogue.cs`, and `DialogueTigger.cs`, in-game dialogues can be triggered by player proximity to specific objects or mouse clicks.
- **Dialogue Manager**: `DialogueManager.cs` is responsible for managing the display and flow of dialogues, including displaying dialogue text and character names.
- **Yes/No Choices**: `YesOrNo.cs` handles branching choices in dialogues, allowing players to make decisions that affect the game's progress.
- **Dialogue Data Model**: `Dialogue.cs` defines a dialogue data model for easy management and storage of dialogue content.

## Cinematic Playback
- **Movie Texture Playback**: `REDcod.cs` and `EDcode.cs` are used for playing cinematic clips in the game to enhance storytelling and atmosphere.

## Game Flow Control
- **Timed Level Transitions**: `REDcod.cs` and `EDcode.cs` include timed transitions to the next game level after movie playback ends.

## UI Interaction
- **Click Interaction**: `NewDialogue.cs` and `DialogueTigger.cs` allow players to trigger dialogues through clicking UI elements, increasing the game's interactivity.

## Ending and Restart
- **Game Over Logic**: `EDcode.cs` contains a timer that automatically triggers game over logic and transitions to a specified level after a certain period following the end of movie playback.

This project demonstrates a complete game loop, including player control, enemy AI, interactions, and UI management. The goal of the game is to advance the plot through player interactions with the game world, while providing challenging enemies and collectible elements.
