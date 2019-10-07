using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;

    private Rigidbody rb;
    // private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // count = 0;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement * speed);
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
        }
    }

    // void OnTriggerEnter(Collider other)
    // {
    //    if(other.gameObject.CompareTag("Pick up"))
    //     {
    //         other.gameObject.SetActive(false);
    //         count += 1;
    //     }
    // }

}
