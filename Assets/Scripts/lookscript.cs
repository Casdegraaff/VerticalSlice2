using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookscript : MonoBehaviour
{
public float speed = 0f;
    private Rigidbody2D rb;
    private Vector3 target;
    private Vector2 moveAmount;
    bool input = false;

    void Start()
    {
        target = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector3 mouseScreen = Input.mousePosition; Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen); transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90);
        if (Input.GetKey(KeyCode.W))
        {
            speed = 10f;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            input = false;
        }

        if (input == false)
        {
            speed = speed - 0.04f;
        }

        if (speed <= 0f)
        {
            speed = speed + 0.04f;
        }

        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            moveAmount = target.normalized * speed;
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }


    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveAmount * Time.fixedDeltaTime);
    }
}
