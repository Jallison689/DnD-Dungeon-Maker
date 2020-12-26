using UnityEngine;

public class AddFloor : MonoBehaviour
{

    public GameObject wall;
    public GameObject floor;
    public GameObject door;
    public GameObject hazard;
    public GameObject enemy;
    public GameObject player;
    public GameObject entity;
    public GameObject nameEntry;

    private GameObject temp;
    private GameObject temp2;
    private string objectName;

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
                Instantiate(wall, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y + 0.5f, GetComponent<Transform>().position.z), new Quaternion());
            }
            else if (GetComponent<Renderer>().material.color == Color.grey)
            {
                Instantiate(floor, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), new Quaternion());
            }
            else if (GetComponent<Renderer>().material.color == Color.blue)
            {
                Instantiate(floor, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), new Quaternion());
                Instantiate(door, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y + 1, GetComponent<Transform>().position.z), new Quaternion());
            }
            else if (GetComponent<Renderer>().material.color == Color.magenta)
            {
                Instantiate(hazard, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), new Quaternion());
            }
            else if (GetComponent<Renderer>().material.color == Color.green)
            {
                Instantiate(floor, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), new Quaternion());
                temp2 = Instantiate(entity, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y + 1, GetComponent<Transform>().position.z), new Quaternion());
            }
            else if (GetComponent<Renderer>().material.color == Color.red)
            {
                Instantiate(floor, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), new Quaternion());
                Instantiate(enemy, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y + 1, GetComponent<Transform>().position.z), new Quaternion());
            }
            else if (GetComponent<Renderer>().material.color == Color.cyan)
            {
                Instantiate(floor, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), new Quaternion());
                Instantiate(player, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y + 1, GetComponent<Transform>().position.z), new Quaternion());
            }
            Destroy(gameObject);
        }
    }
}