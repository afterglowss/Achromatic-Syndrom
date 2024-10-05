using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(instance);
        }
    }

    public Canvas optionCanvas;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (optionCanvas.gameObject.activeSelf) 
            {
                optionCanvas.gameObject.SetActive(false);
            }
            else
            {
                optionCanvas.gameObject.SetActive(true);
            }

        }
    }

}
