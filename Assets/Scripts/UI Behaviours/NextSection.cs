using UnityEngine;

public class NextSection : MonoBehaviour
{
    static bool goToNextSection = false;

    public void onClick()
    {
        goToNextSection = true;
        GameObject.Find("ColouringAreaHolder").GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
    }

    public static bool GoNext()
    {
        return goToNextSection;
    }
}