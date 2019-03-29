using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFacing : MonoBehaviour
{
    public bool isFacingRight = true;
    SpriteRenderer sr;
    Transform enemyPos;
    Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        enemyPos = GameObject.Find("enemy_2").transform;
        playerPos = GameObject.Find("Test_Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        isFacingRight = enemyPos.position.x < playerPos.position.x ? true : false;
        sr.flipX = (isFacingRight == false) ? true : false;
        Debug.Log("Enemy Player Position: " + enemyPos.position.x + "Player Position: " + playerPos.position.x);
    }
}
