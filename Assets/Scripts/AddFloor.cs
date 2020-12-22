using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFloor : MonoBehaviour
{

    public GameObject wall;
    public GameObject floor;
    public GameObject door;

    public void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Renderer>().material.color = ColourType.GetColor();
        }
    }

    private void Update()
    {
        if (NextSection.GoNext())
        {
            if (GetComponent<Renderer>().material.color == Color.black)
            {
                Instantiate(wall, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y,GetComponent<Transform>().position.z), new Quaternion(0, 0, 0, 0));
                Destroy(gameObject);
            }
            else if (GetComponent<Renderer>().material.color == Color.grey)
            {
                Instantiate(floor, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), new Quaternion(0, 0, 0, 0));
                Destroy(gameObject);
            }
            else if (GetComponent<Renderer>().material.color == Color.cyan)
            {
                Instantiate(floor, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), new Quaternion(0, 0, 0, 0));
                Instantiate(door, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y + 1, GetComponent<Transform>().position.z), new Quaternion(0, 0, 0, 0));
                Destroy(gameObject);
            }
            Destroy(gameObject);
        }
    }
}