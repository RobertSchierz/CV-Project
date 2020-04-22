using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displayuicontroller : MonoBehaviour
{

    public GameObject videoplayer;
    public GameObject rightpccanvas;
    public GameObject leftpccanvas;
    public GameObject FPZinfocanvas;
    public GameObject Modellinfocanvas;
    public GameObject Klausureninfocanvas;
    public GameObject videocontrollcanvas;
    public GameObject videoplane;


    private void Update()
    {
        if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.entry)
        {
            LeanTween.alphaCanvas(leftpccanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            LeanTween.alphaCanvas(rightpccanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            LeanTween.alphaCanvas(FPZinfocanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            LeanTween.alphaCanvas(Modellinfocanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            LeanTween.alphaCanvas(Klausureninfocanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            LeanTween.alphaCanvas(videocontrollcanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            videocontrollcanvas.GetComponent<CanvasGroup>().interactable = false;
            videocontrollcanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;
            leftpccanvas.GetComponent<CanvasGroup>().interactable = false;

            if (videoplane != null)
            {
                videoplane.GetComponent<MeshRenderer>().enabled = false;
            }

        }
    }

    public void playVideoOfGame()
    {
        LeanTween.alphaCanvas(Klausureninfocanvas.GetComponent<CanvasGroup>(), 0, 0.0f);
        LeanTween.alphaCanvas(Modellinfocanvas.GetComponent<CanvasGroup>(), 0, 0.0f);
        LeanTween.alphaCanvas(FPZinfocanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
        videoplayer.GetComponent<Rendervideo>().playthevideo("https://robertschierz.de/videos/FPZ.mp4");
        if (rightpccanvas != null)
        {
            LeanTween.alphaCanvas(rightpccanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
        }
    }

    public void playVideoOfModell()
    {
        LeanTween.alphaCanvas(Klausureninfocanvas.GetComponent<CanvasGroup>(), 0, 0.0f);
        LeanTween.alphaCanvas(FPZinfocanvas.GetComponent<CanvasGroup>(), 0, 0.0f);
        LeanTween.alphaCanvas(Modellinfocanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
        videoplayer.GetComponent<Rendervideo>().playthevideo("https://robertschierz.de/videos/printer.mp4");
        if (rightpccanvas != null)
        {
            LeanTween.alphaCanvas(rightpccanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
        }
    }

    public void playVideoOfKlausurenhub()
    {
        LeanTween.alphaCanvas(Modellinfocanvas.GetComponent<CanvasGroup>(), 0, 0.0f);
        LeanTween.alphaCanvas(FPZinfocanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
        LeanTween.alphaCanvas(Klausureninfocanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
        videoplayer.GetComponent<Rendervideo>().playthevideo("https://robertschierz.de/videos/klausurenhub.mp4");
        if (rightpccanvas != null)
        {
            LeanTween.alphaCanvas(rightpccanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
        }
    }





}
