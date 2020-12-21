using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColourType : MonoBehaviour
{

    static int temp;

    public void DropDownOptions()
    {
        temp = gameObject.GetComponent<TMP_Dropdown>().value;
    }

    public static Color GetColor()
    {
        if (temp == 1)
        {
            return Color.magenta;
        }else if (temp == 2)
        {
            return Color.black;
        }
        else if (temp == 3)
        {
            return Color.cyan;
        }
        return Color.grey;
    }
}