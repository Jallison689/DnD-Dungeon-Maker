using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFloor : MonoBehaviour
{
    public void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            this.GetComponent<Renderer>().material.color = ColourType.GetColor();
        }
    }
}