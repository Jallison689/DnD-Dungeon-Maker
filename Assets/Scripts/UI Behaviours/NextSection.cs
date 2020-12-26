using UnityEngine;

public class NextSection : MonoBehaviour
{
    static bool goToNextSection = false;
    static bool goToPlay = false;

    public void onClick()
    {
        goToNextSection = true;
        GameObject.Find("ColouringAreaHolder").GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
        GameObject.Find("TimeToPlay").GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
    }

    public static bool GoNext()
    {
        return goToNextSection;
    }

    public void playTime()
    {
        goToPlay = true;
        GameObject.Find("TimeToPlay").GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
    }

    public static bool timeToPlay()
    {
        return goToPlay;
    }
}