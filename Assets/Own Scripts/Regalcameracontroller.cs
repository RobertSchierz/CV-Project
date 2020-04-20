using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regalcameracontroller : MonoBehaviour
{

    public GameObject regalcamera;



    void Update()
    {
        if (regalcamera.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition == regalcamera.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_Path.MaxPos)
        {

            GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state = States.entry;

        }

        if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.entry)
        {
            regalcamera.GetComponent<CinemachineVirtualCamera>().Priority = 8;
            gameObject.GetComponent<Animator>().SetBool("startregal", false);
            regalcamera.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = 0;
        }

      




    }

    public void regalstart()
    {
        GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state = States.regal;
        regalcamera.GetComponent<CinemachineVirtualCamera>().Priority = 11;
        gameObject.GetComponent<Animator>().SetBool("startregal", true);
   

      

     

    }
}
