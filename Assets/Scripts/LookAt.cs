using UnityEngine;

public class LookAt : MonoBehaviour
{
    private Transform player;

    void Start()
    {
        // Find the player object by tag, assuming your player object has the tag "Player"
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player == null)
        {
            Debug.LogError("Player object not found! Make sure to tag your player object with 'Player'.");
        }
    }

    void Update()
    {
        if (player != null)
        {
            // Rotate towards the player's position
            transform.LookAt(player.position);
        }
    }
}
