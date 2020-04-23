using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Displayuicontroller : MonoBehaviour
{

    public GameObject videoplayer;
    public GameObject rightpccanvas;
    public GameObject leftpccanvas;
    public GameObject FPZinfocanvas;
    public GameObject Modellinfocanvas;
    public GameObject Lernappinfocanvas;
    public GameObject videocontrollcanvas;
    public GameObject videoplane;


    private void Update()
    {
        if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.entry)
        {

            Lernappinfocanvas.GetComponent<CanvasGroup>().interactable = false;
            Lernappinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;

            Modellinfocanvas.GetComponent<CanvasGroup>().interactable = false;
            Modellinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;

            FPZinfocanvas.GetComponent<CanvasGroup>().interactable = false;
            FPZinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;

            LeanTween.alphaCanvas(leftpccanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            LeanTween.alphaCanvas(rightpccanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            LeanTween.alphaCanvas(FPZinfocanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            LeanTween.alphaCanvas(Modellinfocanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            LeanTween.alphaCanvas(Lernappinfocanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
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
        Lernappinfocanvas.GetComponent<CanvasGroup>().interactable = false;
        Lernappinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;

        Modellinfocanvas.GetComponent<CanvasGroup>().interactable = false;
        Modellinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;

        FPZinfocanvas.GetComponent<CanvasGroup>().interactable = true;
        FPZinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = true;

        LeanTween.alphaCanvas(Lernappinfocanvas.GetComponent<CanvasGroup>(), 0, 0.0f);
        LeanTween.alphaCanvas(Modellinfocanvas.GetComponent<CanvasGroup>(), 0, 0.0f);
        LeanTween.alphaCanvas(FPZinfocanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
      //  videoplayer.GetComponent<Rendervideo>().playthevideo("https://robertschierz.de/videos/FPZ.mp4");
        if (rightpccanvas != null)
        {
            LeanTween.alphaCanvas(rightpccanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
        }
    }

    public void playVideoOfModell()
    {

        Lernappinfocanvas.GetComponent<CanvasGroup>().interactable = false;
        Lernappinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;

        FPZinfocanvas.GetComponent<CanvasGroup>().interactable = false;
        FPZinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;

        Modellinfocanvas.GetComponent<CanvasGroup>().interactable = true;
        Modellinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = true;

        LeanTween.alphaCanvas(Lernappinfocanvas.GetComponent<CanvasGroup>(), 0, 0.0f);
        LeanTween.alphaCanvas(FPZinfocanvas.GetComponent<CanvasGroup>(), 0, 0.0f);
        LeanTween.alphaCanvas(Modellinfocanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
       // videoplayer.GetComponent<Rendervideo>().playthevideo("https://robertschierz.de/videos/printer.mp4");
        if (rightpccanvas != null)
        {
            LeanTween.alphaCanvas(rightpccanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
        }
    }

    public void playVideoOfLernapp()
    {
        Modellinfocanvas.GetComponent<CanvasGroup>().interactable = false;
        Modellinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;

        FPZinfocanvas.GetComponent<CanvasGroup>().interactable = false;
        FPZinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;

        Lernappinfocanvas.GetComponent<CanvasGroup>().interactable = true;
        Lernappinfocanvas.GetComponent<CanvasGroup>().blocksRaycasts = true;

        LeanTween.alphaCanvas(Modellinfocanvas.GetComponent<CanvasGroup>(), 0, 0.0f);
        LeanTween.alphaCanvas(FPZinfocanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
        LeanTween.alphaCanvas(Lernappinfocanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
       // videoplayer.GetComponent<Rendervideo>().playthevideo("https://robertschierz.de/videos/lernapp.mp4");
        if (rightpccanvas != null)
        {
            LeanTween.alphaCanvas(rightpccanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
        }
    }

    public void pauseplayvideo()
    {
        if (videoplayer != null)
        {
            if (videoplayer.GetComponent<VideoPlayer>().isPaused)
            {
                videoplayer.GetComponent<VideoPlayer>().Play();
            }

            if (videoplayer.GetComponent<VideoPlayer>().isPlaying)
            {
                videoplayer.GetComponent<VideoPlayer>().Pause();
            }

        }
    }





}
