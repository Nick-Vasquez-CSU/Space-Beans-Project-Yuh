using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Bullet_type1"))
        {
            Destroy(collision.gameObject);
            //if (gameObject.tag.Equals("enemy"))
            //{
                //pushDestroy(gameObject);
            //}
        }
    }
}
