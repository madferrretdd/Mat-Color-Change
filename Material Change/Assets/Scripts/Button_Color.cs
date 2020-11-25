using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Color : MonoBehaviour
{
    public int colorButton;
    private Image myImage;
    public Material_Change matchange;
    // Start is called before the first frame update
    void Start()
    {
        myImage = GetComponent<Image>();
        myImage.color = matchange.VehicleColor[colorButton];
    }

}
