using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 8;

    public float ForwardForce = 1000f;
    public float SideForce = 500f;



// Start is called before the first frame update
void Start()
    {
        Debug.Log("Hello,World!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }

        if  (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 15;
        }

        else
        {
            speed = 8;
        }

        if (Input.GetKey("s"))
        {
            transform.position = transform.position - transform.forward * speed * Time.deltaTime;

        }        
    }
}
