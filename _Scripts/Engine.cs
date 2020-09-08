using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Notifications.Android;
using System.Drawing;

public class Engine : MonoBehaviour
{
    [SerializeField] Text DenemeText = default;
    [SerializeField] Dropdown DenemeDown = default;
    [SerializeField] Dropdown FontTypeDown = default;
    [SerializeField] Font[] Fonts = default;

    public void Start()
    {
        List<string> Sizes = new List<string>() {"SMALL", "NORMAL","BIG" };      //We create our Dropdown lists in start method.
        DenemeDown.AddOptions(Sizes);
        List<string> Fonts = new List<string>() { "DEFAULT", "TYPE 1", "TYPE2","TYPE3" };
        FontTypeDown.AddOptions(Fonts);
    }
    public void ChangeSizes(Dropdown SizesOfDropdown)
    {
        if (SizesOfDropdown.value  == 0)
        {
            DenemeText.fontSize = 40;

        }
        else if (SizesOfDropdown.value == 1)
        {
            DenemeText.fontSize = 80;
        }
        else if (SizesOfDropdown.value == 2)
        {
            DenemeText.fontSize = 120;
        }    
    }
    public void ChangeFontType(Dropdown TypesOfDropdown)
    {
        if (TypesOfDropdown.value == 0)
        {
            DenemeText.font = Fonts[TypesOfDropdown.value];
        }
        else if(TypesOfDropdown.value == 1)
        {
            DenemeText.font = Fonts[TypesOfDropdown.value];
        }
        else if (TypesOfDropdown.value == 2)
        {
            DenemeText.font = Fonts[TypesOfDropdown.value];
        }
        else if (TypesOfDropdown.value == 3)
        {
            DenemeText.font = Fonts[TypesOfDropdown.value];
        }
    }
    
}
