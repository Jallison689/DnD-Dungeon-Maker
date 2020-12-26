using UnityEngine;

public class CameraLook : MonoBehaviour
{

    void Update()
    {
        gameObject.transform.LookAt(2 * gameObject.transform.position - GameObject.Find("Camera").transform.position);
    }
}
