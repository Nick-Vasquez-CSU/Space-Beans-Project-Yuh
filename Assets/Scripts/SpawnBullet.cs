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
       spawnPoint = transform.Find("playerSpawnBullet");
    }

    // Update is called once per frame
    void Update()
    {
        if ((Mathf.Abs(Input.mousePosition.x) > 510 || Mathf.Abs(Input.mousePosition.x) < 370) || (Mathf.Abs(Input.mousePosition.y) > 200 || Mathf.Abs(Input.mousePosition.y) < 80)) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                InstantiateBullet();
            }
        }
    }

    void InstantiateBullet()
    {
        Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
