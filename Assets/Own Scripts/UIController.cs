using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{


    public GameObject entrycanvas;
    public GameObject zuruckcanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.entry)
        {
            LeanTween.alphaCanvas(entrycanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
            entrycanvas.GetComponent<CanvasGroup>().interactable = true;

            LeanTween.alphaCanvas(zuruckcanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            zuruckcanvas.GetComponent<CanvasGroup>().interactable = false;


        }

        if(GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.regal)
        {
            LeanTween.alphaCanvas(entrycanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            entrycanvas.GetComponent<CanvasGroup>().interactable = false;

            LeanTween.alphaCanvas(zuruckcanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            zuruckcanvas.GetComponent<CanvasGroup>().interactable = false;
        }

        if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.ich)
        {
            LeanTween.alphaCanvas(entrycanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            entrycanvas.GetComponent<CanvasGroup>().interactable = false;

            LeanTween.alphaCanvas(zuruckcanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
            zuruckcanvas.GetComponent<CanvasGroup>().interactable = true;
        }

    }
}
