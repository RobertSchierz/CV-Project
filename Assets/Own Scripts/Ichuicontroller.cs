using Lean.Gui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ichuicontroller : MonoBehaviour
{

    public GameObject earth;
    public GameObject car;
    public GameObject wheels;
    public Animator earthanimator;
    public GameObject auslandsbutton;
    public GameObject abschlussbutton;
    public GameObject fuhrerscheinbutton;
    public GameObject zeugnis;

    public GameObject abschlusstext;
    public GameObject auslandtext;
    public GameObject fuhrerscheintext;

    private bool auslandbuttonclicked;
    private bool abschlussbuttonclicked;
    private bool fuhrerscheinbuttonclicked;

    private void Start()
    {
        auslandbuttonclicked = false;
        abschlussbuttonclicked = false;
        fuhrerscheinbuttonclicked = false;
    }


    public void startfuhrerscheinanimation()
    {
        if (fuhrerscheinbutton != null)
        {
            car.GetComponent<MeshRenderer>().enabled = true;
            wheels.GetComponent<MeshRenderer>().enabled = true;
            LeanTween.moveLocalX(car, -2, 2).setEaseInOutBack(); 
            LeanTween.moveLocalX(wheels, -2, 2).setEaseInOutBack(); 

            fuhrerscheinbutton.GetComponent<LeanButton>().interactable = false;
            LeanTween.alphaCanvas(fuhrerscheinbutton.GetComponent<CanvasGroup>(), 0.0f, 1.0f).setOnComplete(fuhrerscheinbuttoncomplete);
        }

        fuhrerscheinbuttonclicked = true;
    }

    public void fuhrerscheinbuttoncomplete()
    {
        if (fuhrerscheintext != null)
        {
            LeanTween.alphaCanvas(fuhrerscheintext.GetComponent<CanvasGroup>(), 1.0f, 1.0f);
        }
    }

    public void startabschlussanimation()
    {
        if (abschlussbutton != null)
        {
            zeugnis.GetComponent<MeshRenderer>().enabled = true;
            LeanTween.moveLocalZ(zeugnis, -0.4f, 2).setEaseInOutBack();


 

            abschlussbutton.GetComponent<LeanButton>().interactable = false;
            LeanTween.alphaCanvas(abschlussbutton.GetComponent<CanvasGroup>(), 0.0f, 1.0f).setOnComplete(abschlussbuttoncomplete);
        }

        abschlussbuttonclicked = true;
    }

    public void abschlussbuttoncomplete()
    {
        if (abschlusstext != null)
        {
            LeanTween.alphaCanvas(abschlusstext.GetComponent<CanvasGroup>(), 1.0f, 1.0f);
        }
    }

    public void startauslandsanimation()
    {
        if (earth != null && !auslandbuttonclicked)
        {
            if (earthanimator != null)
            {
                earthanimator.SetBool("startearth", true);
            }
            earth.GetComponent<MeshRenderer>().enabled = true;
            LeanTween.moveLocalY(earth, 1, 2).setEaseInOutBack();

            if (auslandsbutton != null)
            {
                auslandsbutton.GetComponent<LeanButton>().interactable = false;
                LeanTween.alphaCanvas(auslandsbutton.GetComponent<CanvasGroup>(), 0.0f, 1.0f).setOnComplete(auslandbuttoncomplete);
            }

            auslandbuttonclicked = true;
        }
    }

    public void auslandbuttoncomplete ()
    {
        if (auslandtext != null)
        {
            LeanTween.alphaCanvas(auslandtext.GetComponent<CanvasGroup>(), 1.0f, 1.0f);
        }
    }
}
