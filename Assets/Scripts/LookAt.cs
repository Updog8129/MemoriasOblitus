using UnityEngine;
using UnityEngine.UIElements;

public class LookAt : MonoBehaviour
{
    private Transform player;
    public bool loading;
    public float upAmount = 2f;

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
            if(!loading)
            {
                transform.LookAt(new Vector3(player.position.x, player.position.y + upAmount, player.position.z));
            }
        }
    }

    public void SetBool(bool setBool)
    {
        loading = setBool;
    }
}
