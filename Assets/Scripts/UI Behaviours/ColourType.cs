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
                return Color.blue;
            case 4:
                return Color.grey;
            case 5:
                return Color.cyan;
            case 6:
                return Color.red;
            case 7:
                return Color.green;
            default:
                return Color.white;
        }
    }
}