using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Mastercontroller : MonoBehaviour
{
   

    public States state;


    private void Start()
    {
        state = States.start;
   
    }

    public void setState(String stateName)
    {
        switch (stateName)
        {
            case "start":
                state = States.start;
                break;

            case "entry":
                state = States.entry;
                break;

            case "pc":
                state = States.pcmonitor;
                break;
            case "regal":
                state = States.regal;
                break;
            case "ich":
                state = States.ich;
                break;


            default:
                break;
        }
    }


}

