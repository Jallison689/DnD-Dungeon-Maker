using UnityEngine;

public class Hazards : MonoBehaviour
{

    public Material coverMaterial;
    public Material exposedMaterial;

    private void OnMouseUpAsButton()
    {
        GetComponent<Renderer>().material = exposedMaterial;
    }
}