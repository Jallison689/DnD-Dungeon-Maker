using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A)){
            rb.AddRelativeForce(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.D)){
            rb.AddRelativeForce(Vector3.right);
        }
        if (Input.GetKey(KeyCode.W)){
            rb.AddRelativeForce(Vector3.up);
        }
        else if (Input.GetKey(KeyCode.S)){
            rb.AddRelativeForce(Vector3.down);
        }
        if (Input.GetKey(KeyCode.Q)){
            rb.transform.Rotate(new Vector3(0, -2, 0));
        }
        else if (Input.GetKey(KeyCode.E)){
            rb.transform.Rotate(new Vector3(0, 2, 0));
        }
        if (Input.mouseScrollDelta.y > 0){
            rb.AddRelativeForce(Vector3.forward);
        }
        else if (Input.mouseScrollDelta.y < 0){
            rb.AddRelativeForce(Vector3.back);
        }
    }
}