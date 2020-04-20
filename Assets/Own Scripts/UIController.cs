using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public GameObject[] uibuttons;
    public GameObject entrycanvas;

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
        }

        if(GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.regal)
        {
            LeanTween.alphaCanvas(entrycanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            entrycanvas.GetComponent<CanvasGroup>().interactable = false;
        }

    }
}
