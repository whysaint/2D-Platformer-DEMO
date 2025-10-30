🎮 2D Platformer DEMO

A small demonstration project of a 2D platformer in Unity, created for practicing the engine, animation, and physics.
The project showcases basic player movement, jumping, interaction with moving platforms, and a follow camera.

🧩 Main Mechanics
👤 Player (PlatformerPlayer.cs)

Move left and right using Rigidbody2D.

Jump using physical impulse (ForceMode2D.Impulse).

Ground detection using Physics2D.OverlapArea.

Automatic attachment to moving platforms (MovingPlatform).

Sprite flip when moving in opposite directions.

Running animation through Animator.

🪵 Moving Platforms (MovingPlatform.cs)

Smooth platform movement between two points.

Works with Transform without complex calculations.

Player moves together with the platform when standing on it.

🎥 Camera (FollowCam.cs)

Simple camera follow for the player, keeping position on axes.

Suitable for horizontal levels.

Smooth movement implemented without jerks.

⚙️ Technologies Used

Unity 6 (or Unity 2022+)

C# (MonoBehaviour API)

2D Physics (Rigidbody2D, BoxCollider2D, Physics2D)

Animator Controller

Sprite Renderer

🕹️ How to Run

Clone the repository:

git clone https://github.com/whysaint/2D-Platformer-DEMO.git


Open the project in Unity.

Open the scene SampleScene (or the main project scene).

Play the scene — the character is controlled with arrow keys or A/D, jump with Space.

📁 Project Structure

Assets/
 ├─ Scripts/
 │   ├─ PlatformerPlayer.cs      # Player control
 │   ├─ MovingPlatform.cs        # Moving platform logic
 │   └─ FollowCam.cs             # Follow camera
 ├─ Sprite                       # Spriter for game
 └─ Scenes/                      # Main project scenes


💡 Possible Improvements

Add a death / respawn system.

Implement collectible items and a score counter.

Add landing effects / particles.

Create levels and level transitions.

Add background and music for atmosphere.

👨‍💻 Author
whysa1nt
Developer learning Unity and C#, aiming to create their own indie games.

"Every project is a step toward the dream game."
