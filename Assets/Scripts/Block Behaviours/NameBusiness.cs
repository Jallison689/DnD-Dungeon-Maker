using TMPro;
using UnityEngine;

public class NameBusiness : MonoBehaviour
{

    public GameObject uiNameHolder;

    private string storedName = "";
    private bool getName = false;
    private bool iChooseYou = false;

    private void OnMouseUpAsButton()
    {
        if (!NextSection.timeToPlay())
        {
            Instantiate(uiNameHolder, new Vector3(), new Quaternion());
            getName = true;
        }
        else
        {
            if (!iChooseYou)
            {
                iChooseYou = true;
            }
            else
            {
                iChooseYou = false;
            }
        }
    }

    private void Update()
    {
        if (!NextSection.timeToPlay())
        {
            if (getName)
            {
                storedName = SendName.GiveName();
                if (storedName != "")
                {
                    gameObject.GetComponentInChildren<TMP_Text>().text = storedName;
                    SendName.Delete();
                    getName = false;
                }
            }
        }
        else if (iChooseYou)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddRelativeForce(Vector3.left);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rb.AddRelativeForce(Vector3.right);
            }
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddRelativeForce(Vector3.forward);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                rb.AddRelativeForce(Vector3.back);
            }
        }
    }
}