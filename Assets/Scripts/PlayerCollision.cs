using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        // If the player collides with the object that has the tag "Obstacle", stop the player from moving
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // stops player from moving
            FindObjectOfType<GameManager>().EndGame(); // ends the game
        }
    }
}
