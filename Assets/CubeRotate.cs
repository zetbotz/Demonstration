using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public float RotationRate = 15f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, RotationRate, 0) * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, -1 * RotationRate, 0) * Time.deltaTime);
        }
    }
}
