using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFacing : MonoBehaviour
{
    public bool isFacingRight = true;
    SpriteRenderer sr;
    public GameObject enemyPos;
    Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        playerPos = GameObject.Find("Test_Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        isFacingRight = enemyPos.transform.position.x < playerPos.transform.position.x ? true : false;
        sr.flipX = (isFacingRight == false) ? true : false;
    }
}
