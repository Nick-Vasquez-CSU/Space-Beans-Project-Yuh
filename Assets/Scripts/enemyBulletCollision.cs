using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet_type2"))
        {
            Destroy(collision.gameObject);
        }
    }
}
