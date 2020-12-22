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
        switch (temp)
        {
            case 1:
                return Color.magenta;
            case 2:
                return Color.black;
            case 3:
                return Color.cyan;
            default:
                return Color.grey;
        }
    }
}