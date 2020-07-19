<img src="Logo.png" width="600"/>

# BeatSwitch 

## Design Document

## Contents

  - [Design Log](#Design-Log "Design Log")
  - [Vision Statement](#Vision-Statement "Vision Statement")
  - [Audience, Platform, and Marketing](#Audience,-Platform,-and-Marketing "Audience, Platform, and Marketing")
  - [Gameplay](#Gameplay "Gameplay")
  - [Interface](#Interface "Interface")
  - [Rules/Scoring/Winning Conditions](#Rules/Scoring/Winning-Conditions "Rules/Scoring/Winning Conditions")
  - [Media List](#Media-List "Media List")
  - [Prototype Playtest Feedback](#Prototype-Playtest-Feedback "Prototype Playtest Feedback")

### Design Log

- Version 1.0
- Version 2.0 - additional puzzle/aesthetic component, asset overhaul, platform change
- Version 3.0 - music is altered for a slower tempo; bonus game is added
- Version 4.0 - concrete details specified and revised; preparing for aesthetic overhaul
- Version 5.0 - feedback w/ response at bottom; other additions include minor details, including turn count and board size, revised
- Version 6.0 - redactions of buggy and in-progress features, to be implemented at a later date
- Version 7.0 - minor redactions

### Vision Statement

#### Game Logline

- BeatSwitch: A turn-based, digital, abstract 4-player territory-capture game bound by a tempo; created with the Unity engine and deployed for iOS/itch.io.

#### Gameplay Synopsis

- The digital game board consists of a 17x17 square grid. There are three melodic sequences,
each with a different tempo, that the players may choose from for a given game. With each passing beat, a given player must quickly activate a square to illuminate it with their color. Encapsulation of a diagonal or straight line by two matching colors illuminates the squares between with his or her color. Each player has 70 turns (or “beats”) to occupy as much of the board as possible, with each square having a fixed and labeled point value. The point totals ultimately determine the winner.

### Audience, Platform, and Marketing

#### Target Audience

- BeatSwitch is intended for worldwide appeal to casual and hardcore players alike, of any age and gender, but will likely appeal most to young adults. 

#### Platform

- BeatSwitch will be compatible with iOS devices, but intended for iOS tablets. I think the cross platform support from Unity will make this possible, and I think the gameplay will be experienced best with simple tap gestures (especially on a tablet).

#### System Requirements

- Because BeatSwitch is a fairly simple turn-based game with a minimally abstract geometric design approach, there will be no special hardware requirements, nor will there be any external peripheral requirements for gameplay. Firmware must support Unity.

#### Top Performers

- Othello/Reversi was released in 1983 as an analogue board game. Two players take turns placing their black or white tiles to encapsulate lines of pieces, reversing the pieces of the apposing player to their own color until all the pieces laid are captured, such that one player may no longer make a valid move. The accumulated sales totals are not available. There have not been sequels.

#### Feature Comparison
 
- The appeal to BeatSwitch comes through the addition of up to four players being able to play, as well as the timed turns associated with the tempo-bound gameplay. Other modifications relate specifically to mechanical nuances; nevertheless the digital availability and the rhythmic gameplay will draw in players familiar and unfamiliar with Othello/Reversi, along with the unique deployment as a couch multiplayer “board” game deployed on a tablet.

#### Sales Expectations 

- N/A

##### Legal Analysis

- I will be refining and implementing this game myself, including all assets. There should not exist any legal or financial obligations regarding copyrights, trademarks, contracts, or licensing agreements.

### Gameplay 

#### Overview/Description

- Each player is assigned a corresponding color, (red/yellow/blue/green) and the player to go first is randomly selected. Each player takes turns illuminating a square, laterally adjacent to one of another player’s illuminated squares. Encapsulating one or more squares of one or more players’ (including any unclaimed squares) within a straight line is accomplished by occupying a square on either end of another player’s squares(s), causing the squares in between to be illuminated as your own. Multiple lines may be claimed when taking a single square. After overturning a line of an opponent’s squares, additional lines may not be formed with previously illuminated squares other than the initially occupied square. The winner is determined as being the player with the most accumulated squares, designated by the squares he or she has occupied, after each player has had 60 turns. It is advantageous to work towards capturing squares on the outermost spaces.

#### Controls

- The controls are limited to touch gestures.

### Interface

#### Main Menu
   
- Has options for play, high scores, and settings

#### Player Selection

- Select offline or online
- Matchmaking or custom multiplayer

##### Gameplay View

- Primary top-down perspective for gameplay flow

##### Settings

- Includes options to disable music and sound effects

##### High Scores

### Rules/Scoring/Winning Conditions

- Two-four players can play. This determination is made during setup on the player selection screen. Turns are made in a clockwise fashion, with each of the four players positioned on a different side of the digital square game board grid. Each player only has a few moments to illuminate a square before the next beat strikes and the next player’s turn begins. An invalid move is ignored; a move can still be made during each player’s time window. A colored progress bar indicator in front of each side of the digital game board illuminates to indicate who’s turn it is. With 70 turns each, a four-player game takes 280 / [BPM] minutes to complete. The winner is determined as being the player with the most accumulated points, designated by the squares he or she has occupied, after each player has had 70 turns.

- A white indicator on your side illuminates, synced to the tempo

- You have ≅ one second to illuminate a square for a valid move

- The indicator in front of the next player illuminates/your turn concludes

### Media List

#### Assets

- all assets will be 2D, minimalistic geometric shapes created in Pixelmator 

#### Music/Sound Effects

- all music and sound effects will be created in combination with the TE PO-20 and Logic Pro X. This will include three melodic sequences for gameplay, a menu jingle, and simplistic sounds

### Prototype Playtest Feedback

- After receiving playlets feedback last week, I determined that a number of implementation details needed to be revised. These included removing the limitation of a single touch input allotted per turn, as well as resizing the board to be a bit smaller. Other modifications included a visually stylized tutorial that can be tapped through from the main menu, to brief new players on the rules. Furthermore, the progress bar indicators need to have a midway indicator to designate the best timing for moves to made in order to earn maximum bonus points, as well as to aid players that cannot hear the music or whom would otherwise have trouble timing their moves.
