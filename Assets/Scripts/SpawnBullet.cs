using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
       spawnPoint = transform.Find("spawnPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InstantiateBullet();
        }
    }

    void InstantiateBullet()
    {
        Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
