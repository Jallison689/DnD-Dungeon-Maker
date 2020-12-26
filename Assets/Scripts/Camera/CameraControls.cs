using UnityEngine;

public class CameraControls : MonoBehaviour
{
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddRelativeForce(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddRelativeForce(Vector3.right);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddRelativeForce(Vector3.up);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddRelativeForce(Vector3.down);
        }
        if (Input.mouseScrollDelta.y > 0)
        {
            rb.AddRelativeForce(Vector3.forward);
        }
        else if (Input.mouseScrollDelta.y < 0)
        {
            rb.AddRelativeForce(Vector3.back);
        }
    }
}