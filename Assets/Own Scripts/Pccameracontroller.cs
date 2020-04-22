using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pccameracontroller : MonoBehaviour
{

    public GameObject pcmonitor1;
    public GameObject pcmonitor2;
    public GameObject pcleftcanvas;
    public GameObject pcrightcanvas;
    public GameObject zuruckpanel; 
    


    void Update()
    {
        if (gameObject.GetComponent<CinemachineVirtualCamera>() != null)
        {
            if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.pcmonitor)
            {
                pcstate();
            }

           
            
          if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.entry)
            {
                gameObject.GetComponent<CinemachineVirtualCamera>().Priority = 9;
                gameObject.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = 0;
                gameObject.GetComponent<Animator>().SetBool("statepc", false);
                pcmonitor1.GetComponent<Animator>().SetBool("startmonitor", false);
                pcmonitor2.GetComponent<Animator>().SetBool("startmonitor", false);

            }

         

        }
    }

    private void pcstate()
    {
        gameObject.GetComponent<CinemachineVirtualCamera>().Priority = 11;
        gameObject.GetComponent<Animator>().SetBool("statepc", true);
        if (gameObject.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition == gameObject.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_Path.MaxPos)
        {

            if (zuruckpanel != null)
            {
                if (zuruckpanel.GetComponent<CanvasGroup>().alpha == 0)
                {
                LeanTween.alphaCanvas(zuruckpanel.GetComponent<CanvasGroup>(), 1, 0.5f);
                zuruckpanel.GetComponent<CanvasGroup>().interactable = true;
                }
                  
            }

            if (pcmonitor1 != null && pcmonitor2 != null)
            {
                pcmonitor1.GetComponent<Animator>().SetBool("startmonitor", true);
                pcmonitor2.GetComponent<Animator>().SetBool("startmonitor", true);
            }

            if (pcleftcanvas != null)
            {
                if (pcmonitor1.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("PCdisplay") && 
                    pcmonitor1.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= pcmonitor1.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length)
                {
                   
                    LeanTween.alphaCanvas(pcleftcanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
                    pcleftcanvas.GetComponent<CanvasGroup>().interactable = true;
                }
                
            }
        }
    }
}
