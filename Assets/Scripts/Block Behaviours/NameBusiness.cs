using TMPro;
using UnityEngine;

public class NameBusiness : MonoBehaviour
{

    public GameObject uiNameHolder;

    private static string storedName = "";

    private void OnMouseUpAsButton()
    {
        if (storedName != gameObject.GetComponentInChildren<TMP_Text>().text)
        {
            Instantiate(uiNameHolder, new Vector3(), new Quaternion());
        }
        else
        {

        }
    }

    public static void TakeName(string givenName)
    {
        storedName = givenName;
    }

    private void Update()
    {
        if (storedName != "")
        {
            gameObject.GetComponentInChildren<TMP_Text>().text = storedName;
        }
    }
}