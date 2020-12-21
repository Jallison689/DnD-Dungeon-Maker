using TMPro;
using UnityEngine;

public class AreaSize : MonoBehaviour
{

    int areaSize;
    public GameObject floor;

    public void MakeArea()
    {
        areaSize = int.Parse(GameObject.Find("AreaSize").GetComponent<TMP_InputField>().text);
        if (areaSize != 0)
        {
            GameObject.Find("GenerateAreaHolder").GetComponent<Canvas>().planeDistance = 0;
            GameObject.Find("ColouringAreaHolder").GetComponent<Canvas>().planeDistance = 100;
            for (int i = 0; i < areaSize; i++)
            {
                for (int j = 0; j < areaSize; j++)
                {
                    Instantiate(floor, new Vector3(i, 1, j), new Quaternion(0, 0, 0, 0));
                }
            }
        }
    }
}