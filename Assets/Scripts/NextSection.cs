using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSection : MonoBehaviour
{
    static bool goToNextSection = false;

    public void onClick()
    {
        goToNextSection = true;
    }

    public static bool GoNext()
    {
        return goToNextSection;
    }
}