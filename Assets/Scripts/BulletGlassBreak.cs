using UnityEngine;

public class BulletGlassBreak : MonoBehaviour
{
    public float speed = 10f; // Speed of the bullet
    private Vector3 direction; // Direction of the bullet

    void Start()
    {
        // Set initial direction to forward (assuming bullet is facing forward)
        direction = transform.right;
    }

    void Update()
    {
        // Move the bullet forward
        transform.position += direction * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        // Check if the object has the tag "BulletDestroy"
        if (other.CompareTag("BulletDestroy"))
        {
            // Destroy the object the bullet collided with
            Destroy(other.gameObject);
        }

        // Always destroy the bullet when it hits something
        Destroy(gameObject);
    }
}
