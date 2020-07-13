# BeatSwitch 

## Design Document

### Design History
Version 1.0

### Vision Statement

#### Game Logline

- Beat Switch: A turn-based, digital, abstract 4-player territory-capture game bound by a tempo. Gameplay Synopsis
- The digital game board consists of a 17x17 square grid. There are three melodic sequences,
each with a different tempo, that the players may choose from for a given game. With each passing beat, a given player must quickly activate a square to illuminate it with their color. Encapsulation of a diagonal or straight line by two matching colors illuminates the squares between with his or her color. Each player has 70 turns (or “beats”) to occupy as much of the board as possible, with each square having a fixed and labeled point value. The point totals ultimately determine the winner.

### Audience, Platform, and Marketing

#### Target Audience

- Beat Switch is intended for worldwide appeal to casual and hardcore players alike, of any age
and gender, but will likely appeal most to young adults. Platform
- Beat Switch will be compatible with macOS, Linux, and Windows operating systems. I think the cross platform support from Unity will make this possible, and I think the gameplay will be best served with simple point and click gestures. Perhaps down the line it would also play well on mobile and tablet touch screens.
System Requirements
- Because Beat Switch is a fairly simple turn-based game with a minimally abstract geometric
design approach, there will be no special hardware requirements, nor will there be any external peripheral requirements for gameplay.

#### Top Performers

- Othello/Reversi was released in 1983 as an analogue board game. Two players take turns
placing their black or white tiles to encapsulate lines of pieces, reversing the pieces of the apposing player to their own color until all the pieces laid are captured, such that one player may no longer make a valid move. The accumulated sales totals are not available. There have not been sequels.
Feature Comparison
- The appeal to Beat Switch comes through the addition of up to four players being able to play,
as well as the timed turns associated with the tempo-bound gameplay. Other modifications relate specifically to mechanical nuances; nevertheless the digital availability and the rhythmic gameplay will draw in players familiar and unfamiliar with Othello/Reversi.

#### Sales Expectations - N/A

##### Legal Analysis

- I will be refining and implementing this game myself, including all assets. There should not exist any legal or financial obligations regarding copyrights, trademarks, contracts, or licensing agreements.
Gameplay

### Gampleay Overview/Description

- each player is assigned a corresponding color, (red/yellow/blue/green) and the player to go first is randomly selected. Each player takes turns illuminating a square, laterally or diagonally adjacent to one of another player’s illuminated squares. Encapsulating one or more squares of one or more players’ (including any unclaimed squares) within a straight or diagonal line is accomplished by occupying a square on either end of another player’s squares(s), causing the squares in between to be illuminated as your own. Multiple lines may be claimed when taking a single square. After overturning a line of an opponent’s squares, additional lines may not be formed with previously illuminated squares other than the initially occupied square. The winner is determined as being the player with the most accumulated squares, designated by the squares he or she has occupied, after each player has had 70 turns. It is advantageous to work towards capturing squares on the outermost spaces, especially the corner spaces as they cannot be reclaimed.

#### Controls

- The controls are limited to mouse movements and clicks.
Interface

#### Main Menu
   
Has options for play, high scores, and settings
Player Selection

##### Gameplay View

- Matchmaking or custom multiplayer
  Settings
- includes options to disable music and sound effects
- includes player’s top point totals upon winning games in the past

### Rules/Scoring/Winning Conditions

Two-four players can play. This determination is made during setup on the player selection screen. Turns are made in a clockwise fashion, with each of the four players positioned on a different side of the digital square game board grid. Each player only has a few moments to illuminate a square before the next beat strikes and the next player’s turn begins. An invalid move is ignored; a move can still be made during each player’s time window. A white indicator in front of each side of the digital game board illuminates to indicate who’s turn it is. Only one input is accepted per beat. If a player makes a move prior to their turn, or after their turn, inadvertently making a move for another player, the player in violation is removed from the game. Doing so reverts all of their illuminated squares to blank squares. All following rotations automatically skip that player’s turn. With 70 turns each, a four-player game takes 280 / [BPM] minutes to complete, or less if any players are ejected during the game. There are three melodic sequences included, each with a different fixed number of BPM. The winner is determined as being the player with the most accumulated points, designated by the squares he or she has occupied, after each player has had 70 turns.

- A white indicator on your side illuminates, synced to the tempo
- You have ≅ one second to illuminate a square for a valid move
- The indicator in front of the next player illuminates/your turn concludes

### Media List

#### Assets

- all assets will be 2D, minimalistic geometric shapes created in Pixelmator Music/Sound Effects
- all music and sound effects will be created in combination with the TE PO-20 and Logic Pro X. This will include three melodic sequences for gameplay, a menu jingle, and simplistic sounds

Beat Switch will be created with the Unity engine and delivered on itch.io

