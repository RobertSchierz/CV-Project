using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ichcameracontroller : MonoBehaviour
{
    public GameObject ichcam;
    public GameObject ichcanvas;


    void Update()
    {
        if (ichcam.GetComponent<CinemachineVirtualCamera>() != null)
        {
            if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.ich)
            {
                ichcamstart();
            }

            if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.entry)
            {
                ichcam.GetComponent<CinemachineVirtualCamera>().Priority = 9;
                ichcam.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = 0;
                LeanTween.alphaCanvas(ichcanvas.GetComponent<CanvasGroup>(), 0.0f, 0.5f);
                gameObject.GetComponent<Animator>().SetBool("startich", false);
            }







        }
    }

    private void ichcamstart()
    {
        ichcam.GetComponent<CinemachineVirtualCamera>().Priority = 11;
        gameObject.GetComponent<Animator>().SetBool("startich", true);
    }
}
