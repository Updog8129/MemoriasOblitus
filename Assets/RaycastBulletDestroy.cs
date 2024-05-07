using UnityEngine;

public class RaycastBulletDestroy : MonoBehaviour
{
    public bool loaded;
    public Animator animator;

    [SerializeField] private GameObject prefabBullet;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private LookAt looker;

    private void Start()
    {
        animator = GetComponent<Animator>();
        loaded = false;
    }

    void Update()
    {
        // Shoot a raycast forward from the object's position
        if (loaded)
        {
            animator.SetBool("shooting", true);
        }
    }

    public void SpawnBullet()
    {
        // Calculate rotation to make the bullet face the same direction as the spawner
        Quaternion bulletRotation = Quaternion.LookRotation(transform.forward);

        Instantiate(prefabBullet, bulletSpawn.position, bulletRotation);
    }

    public void SetShooting()
    {
        animator.SetBool("shooting", false);

        if (gameObject.GetComponent<LookAt>() != null)
        {
            looker.loading = false;
        }
    }

    public void Loading(bool loading)
    {
        loaded = loading;
    }
}
