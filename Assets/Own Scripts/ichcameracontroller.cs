using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ichcameracontroller : MonoBehaviour
{
    public GameObject ichcam;

    // Update is called once per frame
    void Update()
    {
        if (ichcam.GetComponent<CinemachineVirtualCamera>() != null)
        {
            if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.ich)
            {
                ichcamstart();
            }



          



        }
    }

    private void ichcamstart()
    {
        ichcam.GetComponent<CinemachineVirtualCamera>().Priority = 11;
        gameObject.GetComponent<Animator>().SetBool("startich", true);
    }
}
