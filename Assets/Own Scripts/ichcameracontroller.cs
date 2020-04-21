using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ichcameracontroller : MonoBehaviour
{
    public GameObject ichcam;
    public GameObject ichcanvas;
    public GameObject zuruckcanvas;
    public GameObject mainuicanvas;


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
                ichcanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;
                if (ichcam.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition == ichcam.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_Path.MinPos)
                {
                    ichcam.GetComponent<CinemachineVirtualCamera>().Priority = 7;
                    ichcam.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = 0;
                    




                }
                else
                {
                    LeanTween.alphaCanvas(zuruckcanvas.GetComponent<CanvasGroup>(), 0.0f, 0.5f);
                    zuruckcanvas.GetComponent<CanvasGroup>().interactable = false;
                    mainuicanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
                    mainuicanvas.GetComponent<CanvasGroup>().interactable = false;
                }
       

                LeanTween.alphaCanvas(ichcanvas.GetComponent<CanvasGroup>(), 0.0f, 0.5f);
                
                gameObject.GetComponent<Animator>().SetBool("startich", false);
            }







        }
    }

    private void ichcamstart()
    {
        ichcam.GetComponent<CinemachineVirtualCamera>().Priority = 11;
        gameObject.GetComponent<Animator>().SetBool("startich", true);
        ichcanvas.GetComponent<CanvasGroup>().interactable = true;
        ichcanvas.GetComponent<CanvasGroup>().blocksRaycasts = true;

        if (ichcam.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition == ichcam.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_Path.MaxPos)
        {
            LeanTween.alphaCanvas(zuruckcanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
            zuruckcanvas.GetComponent<CanvasGroup>().interactable = true;
        }

    }
}
