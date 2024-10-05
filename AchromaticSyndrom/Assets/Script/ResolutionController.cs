using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.UI;


public class ResolutionController : MonoBehaviour
{

    public Resolution[] resolutions = Screen.resolutions;

    public Dropdown resolutionDropdown;

    private void Start()
    {
        foreach (Resolution res in resolutions)
        {
            //print(res.width + "x" + res.height);
            var MAX = GCD(res.width, res.height);
            if ((res.width/MAX == 10)&&(res.height/MAX == 0))
            {
                resolutionDropdown.options.Add(new Dropdown.OptionData(res.ToString()));
            }
        }
    }

    private int GCD(int width, int height)
    {
        throw new NotImplementedException();
    }

    public void ChangeResolution(Resolution resolution)
    {
        Screen.SetResolution(resolution.width, resolution.height, true);
    }
}
