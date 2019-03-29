using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    public Rigidbody2D rb;
    public int power = 2500;
    // Start is called before the first frame update
    void Start()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var mouseDir = mousePos - gameObject.transform.position;
        mouseDir.z = 0.0f;
        mouseDir = mouseDir.normalized;
        rb.AddForce(mouseDir * power);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
