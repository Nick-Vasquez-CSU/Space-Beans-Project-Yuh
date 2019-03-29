using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAddForce : MonoBehaviour
{
    public Rigidbody2D rb;
    public int power = 1000;
    // Start is called before the first frame update
    void Start()
    {
        Transform playerPos = GameObject.Find("Test_Player").transform;
        rb.AddForce(playerPos.position * power);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}