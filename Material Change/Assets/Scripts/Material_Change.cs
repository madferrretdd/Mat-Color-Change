using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material_Change : MonoBehaviour
{
    public int colorValue;
    public Color[] VehicleColor;

    public void OnClickColorPick(int whichColor)
    {
        colorValue = whichColor;
        Material mat = GetComponent<MeshRenderer>().material;
        mat.SetColor("_Color", VehicleColor[whichColor]);
    }


}
