using UnityEngine;

public class LaunchScript : MonoBehaviour
{
    public float launchForce = 10f; // The force to apply when launching the player
    public float launchInterval = 5f; // The initial interval between each launch
    public float minInterval = 1f; // The minimum interval between launches

    private CharacterController playerController; // Reference to the player's CharacterController
    public float timer = 0f; // Timer to control launching frequency

    void Start()
    {
        // Find the player's CharacterController
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>();

        if (playerController == null)
        {
            Debug.LogError("Player CharacterController not found!");
        }
    }

    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Check if it's time to launch the player
        if (timer >= launchInterval)
        {
            LaunchPlayer();
            // Reset the timer
            timer = 0f;
            // Decrease the launch interval (but ensure it doesn't go below the minimum)
            launchInterval = Mathf.Max(launchInterval - 0.5f, minInterval);
        }
    }

    void LaunchPlayer()
    {
        // Apply the launch force to the player
        Vector3 launchDirection = transform.up * launchForce;
        playerController.Move(launchDirection * Time.deltaTime);
    }
}
