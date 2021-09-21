using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    enum ColorCube  { Red, Blue, Green };
    public MeshRenderer curRenderMaterial;
    public Material RedMaterial;
    public Material BlueMaterial;
    public Material GreenMaterial;
    ColorCube curColor = ColorCube.Green;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter");
        switch (curColor)
        {
            case ColorCube.Red:
                curColor = ColorCube.Blue;
                curRenderMaterial.material = BlueMaterial;
                break;
            case ColorCube.Blue:
                curColor = ColorCube.Green;
                curRenderMaterial.material = GreenMaterial;
                break;
            case ColorCube.Green:
                curColor = ColorCube.Red;
                curRenderMaterial.material = RedMaterial;
                break;
            default:
                break;
        }

       
    }
}
