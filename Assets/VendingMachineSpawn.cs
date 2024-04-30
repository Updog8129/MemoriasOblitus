using UnityEngine;

public class VendingMachineSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPoint;
    public float launchForce = 10f;
    public float upwardForce = 5f;

    public void SpawnAndLaunchObject()
    {
        GameObject spawnedObject = Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

        Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Calculate launch direction
            Vector3 launchDirection = spawnPoint.right + spawnPoint.up;
            launchDirection.Normalize();

            // Apply forces
            rb.AddForce(launchDirection * launchForce, ForceMode.Impulse);
            rb.AddForce(Vector3.up * upwardForce, ForceMode.Impulse);
        }
        else
        {
            Debug.LogError("Spawned object does not have a Rigidbody component.");
        }
    }
}
