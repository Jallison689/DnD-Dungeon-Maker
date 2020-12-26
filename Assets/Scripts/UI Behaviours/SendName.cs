using TMPro;
using UnityEngine;

public class SendName : MonoBehaviour
{

    private static string temp = "";

    public void GetAndSendName()
    {
        temp = (GameObject.Find("NameEntry").GetComponent<TMP_InputField>().text);
    }

    public static string GiveName()
    {
        return temp;
    }

    public static void Delete()
    {
        temp = "";
        Destroy(GameObject.Find("NameEntryHolder(Clone)"));
    }
}