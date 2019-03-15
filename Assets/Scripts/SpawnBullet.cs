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
        Debug.Log("Mouse Position X");
        Debug.Log(Mathf.Abs(Input.mousePosition.x));
        Debug.Log("Mouse Position Y");
        Debug.Log(Mathf.Abs(Input.mousePosition.y));
        Debug.Log("Distance: ");
        Debug.Log((Mathf.Sqrt((Mathf.Pow(Mathf.Abs(Input.mousePosition.x), 2) + Mathf.Pow(Mathf.Abs(Input.mousePosition.y), 2)))));

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
