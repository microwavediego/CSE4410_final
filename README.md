# Submission for CSE4410 Midterm Spring 2024 

# Submitted by:
- Diego Espinoza
- Christopher De La Cruz
- Mohammad Kaissi
- Michael Herman

What's Included:
- Included in this submission is our folders containing our scripts, prefabs, sample scene, and sprites. We also included an mp4 recording of our working game.

Gameplay:
- Our game is a simple 2D platformer where the objective is to shoot spawning enemies and remain alive as long as possible. Our player (stickman) is equipped with projectiles (detergent) and can run and jump on different platforms. It faces three types of opponents which are jerseys, pants, and hats. The jeans and jerseys continuously spawn in different areas and follow predetermined paths either North-South or East-West. The hats are spawned in only once at the beginning of the game and these know the player location and follow it around. Enemies have a health of 1 and once they are hit with detergent they vanish and our score is increased. The player has a health of 5 and loses 1 health each time it makes contact with an enemy. Once health reaches 0 the player is destroyed and there is a prompt asking for user to start game all over.

How it works. Brief description of each script file:
- BoxController - Updates the 3 text boxes in our game for score, health, and game over.
- DetergentMovement - When we instantiate a new projectile (detergent) this script uses RigidBody for movement and also detects collisions, performs calls accordingly.
- EnemyHealth - This is called to destroy enemy gameObject when it collides with projectile. Also calls for an update to the score.
- EnemyMovement - Attached to the hats, this script allows these enemies to know the current player location and move towards it. 
- EnemySpawn - We pass in prefabs and this spawns enemies at a preset spawnRate.
- JeansAI - Attached to the jeans, this script continuously moves jean enemies up and down within the camera.
- MovingPlatform - In the game background there is a ladder, this script moves an invisible one-way platform up and down to allow player to "use" ladder.
- PlatformPlayer - Performs player movement, animations, detects collisions with enemies, and destroys player if health is 0.
- PlayerShoot - If we receive a mouse click, shoot detergent projectile in the correct direction.
- ShirtAI - Attached to the jerseys, this script continuously moves jersey enemies left and right within the camera.
- StartButton - Re-loads our Sample Scene when a user clicks the Start button

File Share:
- Our team is sharing unity packages in the following Google Drive - https://drive.google.com/drive/folders/1WoGuAJnyyvJPexYNVYiGTHyiFHTK9L7g. Please let us know if there are any issues accessing package.

