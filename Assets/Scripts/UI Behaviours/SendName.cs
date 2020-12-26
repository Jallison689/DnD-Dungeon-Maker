using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SendName : MonoBehaviour
{

    private string temp;

    public void GetAndSendName()
    {
        temp = (GameObject.Find("NameEntry").GetComponent<TMP_InputField>().text);
        NameBusiness.TakeName(temp);
        Destroy(GameObject.Find("NameEntryHolder(Clone)"));
    }
}
