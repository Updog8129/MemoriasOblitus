using UnityEngine;

public class RaycastBulletDestroy : MonoBehaviour
{
    public float raycastDistance = 10f; // Distance to shoot the raycast
    public LayerMask layerMask; // Layer mask to filter objects
    public string bulletDestroyTag = "BulletDestroy"; // Tag to look for
    public bool loaded;

    private void Start()
    {
        loaded = false;
    }

    void Update()
    {
        // Shoot a raycast forward from the object's position
        if(loaded)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, raycastDistance, layerMask))
            {
             // Check if the hit object has the specified tag
                if (hit.collider.CompareTag(bulletDestroyTag))
                {
                    // Destroy the hit object
                    Destroy(hit.collider.gameObject);
                    Loading(false);
                }
            }

        }
    }

    public void Loading(bool loading)
    {
        loaded = loading;
    }
}
