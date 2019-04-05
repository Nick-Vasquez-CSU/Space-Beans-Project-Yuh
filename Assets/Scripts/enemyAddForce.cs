using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAddForce : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveDir;
    public int power = 1;
    // Start is called before the first frame update
    void Start()
    {
        Transform playerPos = GameObject.Find("Test_Player").transform;
        moveDir = (playerPos.position - transform.position).normalized * power;
        rb.velocity = new Vector2(moveDir.x, moveDir.y);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}