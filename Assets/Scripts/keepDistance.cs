using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepDistance : MonoBehaviour
{
    private bool isFacingRight = true;
    public float speed;
    public float distance;
    public float gap;
    private Rigidbody2D rb2d;
    Transform enemyPos;
    Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        rb2d = GetComponent<Rigidbody2D>();
        enemyPos = GameObject.Find("enemy_2").transform;
        playerPos = GameObject.Find("Test_Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        isFacingRight = enemyPos.position.x < playerPos.position.x ? true : false;
        if (isFacingRight == true)
        {
            if ((playerPos.position.x - enemyPos.position.x) > distance)
            {
                rb2d.velocity = new Vector2(speed, 0);
                checkY(speed);
            }
            else if ((playerPos.position.x - enemyPos.position.x) < distance - gap)
            {
                rb2d.velocity = new Vector2(-speed, 0);
                checkY(-speed);
            }
            else
            {
               rb2d.velocity = new Vector2(0, 0);
            }
        }
        else
        {
            if ((enemyPos.position.x - playerPos.position.x) > distance)
            {
                rb2d.velocity = new Vector2(-speed, 0);
                checkY(-speed);
            }
            else if ((enemyPos.position.x - playerPos.position.x) < distance - gap)
            {
                rb2d.velocity = new Vector2(speed, 0);
                checkY(speed);
            }
            else
            {
                rb2d.velocity = new Vector2(0, 0);
            }
        }
    }
    void checkY(float xSpeed)
    {
        if ((playerPos.position.y - enemyPos.position.y) > 1)
        {
            rb2d.velocity = new Vector2(xSpeed, speed / 2);
        }
        else if ((playerPos.position.y - enemyPos.position.y) < -1)
        {
            rb2d.velocity = new Vector2(xSpeed, -speed / 2);
        }
        else
        {
            rb2d.velocity = new Vector2(xSpeed, 0);
        }
    }
}

