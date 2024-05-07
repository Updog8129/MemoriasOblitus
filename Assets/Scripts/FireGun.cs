using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    [SerializeField] private float delaySpeed = 2f;
    [SerializeField] private GameObject prefabBullet;
    [SerializeField] private Transform bulletSpawn;

    private Quaternion bulletRotation;

    void Start()
    {
        InvokeRepeating("SpawnBullet", delaySpeed, delaySpeed);
    }

    public void SpawnBullet()
    {
        bulletRotation = Quaternion.LookRotation(bulletSpawn.forward);
        Instantiate(prefabBullet, bulletSpawn.position, bulletRotation);
    }
}
