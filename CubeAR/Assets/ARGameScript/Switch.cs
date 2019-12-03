using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Switch : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject good;
    public GameObject bad;
    public int number = 0;
    public int maxNumber = 2;
    public VirtualButtonBehaviour vb;

    private void Start()
    {
        vb.RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        number++;
        if (number >= maxNumber)
        {
            bad.SetActive(true);
            good.SetActive(false);
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }
}

