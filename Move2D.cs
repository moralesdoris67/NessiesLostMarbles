using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Move2D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isGrounded = false;

    void Start()
    {

    }

    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump")  && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 3f), ForceMode2D.Impulse);
        }

    }
}