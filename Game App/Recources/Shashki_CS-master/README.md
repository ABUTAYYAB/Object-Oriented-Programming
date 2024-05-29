# Shashki-2D-Race

2D game. Move car and avoid approaching obstacle. Simple Tkinter game with primitive gameplay.

## Controls
* You can control *player_car* using keyboard arrows (Left, Right), or [A] / [D] keys
* Try to avoid incoming obstacle.

## Code
* This minigame was made using Windows Forms.
  * Game consists of just 3 labels:
    * *player_label*,
    * *car_label*,
    * *lose_label*.
* Minigame uses one infinite loop for all actions:
  * loop allows to move label down which gives the illusion of speed.
  * loop checks car collision.
  * loop checks coordinates of obstacles, and respawns them in case of exiting the window.
