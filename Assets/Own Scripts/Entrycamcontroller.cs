using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrycamcontroller : MonoBehaviour
{

    public bool startfinished;
    // Start is called before the first frame update
    void Start()
    {
        startfinished = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<CinemachineVirtualCamera>() != null)
        {

            if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.start)
            {
                gameObject.GetComponent<CinemachineVirtualCamera>().Priority = 10;
            }

            if (gameObject.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition == gameObject.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>().m_Path.MaxPos)
            {
                if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state != States.entry && !startfinished)
                {
                    GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state = States.entry;
                    startfinished = true;
                }
             
            }
        }
    }
}
