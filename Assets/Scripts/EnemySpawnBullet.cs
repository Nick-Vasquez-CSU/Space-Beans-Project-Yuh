using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 3;
    public float timer = 0;
    Transform spawnPoint;
    Transform spawnPoint1;
    Transform spawnPoint2;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        timer = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        if(sr.flipX == false)
        {
            spawnPoint = transform.Find("spawnPoint");
            spawnPoint1 = transform.Find("spawnPoint1");
            spawnPoint2 = transform.Find("spawnPoint2");
        }
        else
        {
            spawnPoint = transform.Find("spawnLPoint");
            spawnPoint1 = transform.Find("spawnLPoint1");
            spawnPoint2 = transform.Find("spawnLPoint2");
        }
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            InstantiateBullet();
            timer = fireRate;   
        }
    }

    void InstantiateBullet()
    {
        Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        Instantiate(bulletPrefab, spawnPoint1.position, spawnPoint1.rotation);
        Instantiate(bulletPrefab, spawnPoint2.position, spawnPoint2.rotation);
    }
}
