# AsteraX-UCP-C01-V13---Points-Jumps-and-UI-Challenge
Implementing Points, Jumps, and UI

## Challenge 4 | Prepare for Peer Review
Refer to About the Challenges and Solutions for more information about readings of this type.

For this challenge, you will complete and submit your project for review and grading by your peers. Before starting the peer review, be ready to implement the required features in your project:

Tasks to Complete:

Each of the following tasks (the bulleted items) will be worth 1 point each (11 points total):

Implement Scoring

Shooting Asteroids should earn the player points.
When an Asteroid is smaller, it should be worth more points, as outlined in the Requirements Doc.
Implement Player Lives (Jumps)

When the PlayerShip collides with an Asteroid, the PlayerShip should disappear (it teleports away from danger) and reappear in a safe section of the screen after a short time (a Jump).
When the PlayerShip jumps, the number of Jumps remaining should be depleted.
When the PlayerShip jumps, the Asteroid that hit the PlayerShip should be destroyed, and the children of that Asteroid should be promoted to top-level Asteroids (as in the previous challenge).
When the PlayerShip collides with an Asteroid with 0 Jumps remaining, the Player Ship should be destroyed.
When the PlayerShip is destroyed, the game should end and the Scene should reload after a short delay.
Implement a simple HUD

The HUD should show the number of Jumps remaining
The HUD should show the Current Score
Be sure to implement the 9-slice boxes around each Text field
Write readable code

Use professional scripting practices, such as descriptive method names and comments, to make sure your code is easy to read by other programmers.
