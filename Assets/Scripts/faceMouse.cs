using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceMouse : MonoBehaviour
{
    public float speed = 5f;
    public bool isFacingRight = true;
    SpriteRenderer sr;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.parent.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

        isFacingRight = (transform.localEulerAngles.z >= 0 && transform.localEulerAngles.z <= 90 || transform.localEulerAngles.z >= 270 && transform.localEulerAngles.z <= 360) ? true : false;
        sr.flipY = (isFacingRight == false) ? true : false;
        transform.localPosition = (isFacingRight == false) ? new Vector3(-.5f, 0, transform.position.z) : new Vector3(.5f, 0, transform.position.z);
    }
}
