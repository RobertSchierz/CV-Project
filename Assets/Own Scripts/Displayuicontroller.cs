using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Displayuicontroller : MonoBehaviour
{

   
    public GameObject rightpccanvas;
    public GameObject leftpccanvas;
    public GameObject FPZinfocanvas;
    public GameObject Modellinfocanvas;
    public GameObject Lernappinfocanvas;
    public GameObject videocontrollcanvas;

    public GameObject[] videoplayers;

    public GameObject videocam;




    


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

        

        }
    }


    public void stopthevideo()
    {

        if (videocam != null)
        {
            videocam.GetComponent<CinemachineVirtualCamera>().Priority = 6;
            videocam.GetComponent<Animator>().SetBool("startvideocam", false);
        }

    }

    public void startVideo()
    {
        if (videoplayers.Length != 0)
        {

            if (videocam != null)
            {
                videocam.GetComponent<CinemachineVirtualCamera>().Priority = 11;
                videocam.GetComponent<Animator>().SetBool("startvideocam", true);
            }

            bool targetfound = false;
            foreach (GameObject player in videoplayers)
            {
                foreach (Transform children in player.transform)
                {
                    if (children.gameObject.GetComponent<MeshRenderer>() != null && children.gameObject.GetComponent<MeshRenderer>().enabled)
                    {
                        targetfound = true;
                    }

                    if (targetfound && children.gameObject.GetComponent<VideoPlayer>() != null)
                    {
                       
                            children.gameObject.GetComponent<VideoPlayer>().Play();
                            return;
                    }
                }

            }
        }
    }

    public void resetallotherplayer()
    {

       
        if (videoplayers.Length != 0)
        {
            foreach (GameObject player in videoplayers)
            {
                foreach (Transform children in player.transform)
                {
                    if (children.gameObject.GetComponent<MeshRenderer>() != null)
                    {
                        children.gameObject.GetComponent<MeshRenderer>().enabled = false;
                    }

                    if (children.gameObject.GetComponent<VideoPlayer>() != null)
                    {
                        children.gameObject.GetComponent<VideoPlayer>().Stop();
                    }
                }

            }
        }
    }

    public void playVideoOfGame()
    {
        resetallotherplayer();
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
        resetallotherplayer();
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
        resetallotherplayer();
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
        if (videoplayers.Length != 0)
        {
            bool targetfound = false;
            foreach (GameObject player in videoplayers)
            {
                foreach (Transform children in player.transform)
                {
                    if (children.gameObject.GetComponent<MeshRenderer>() != null && children.gameObject.GetComponent<MeshRenderer>().enabled)
                    {
                        targetfound = true;  
                    }

                    if (targetfound && children.gameObject.GetComponent<VideoPlayer>() != null)
                    {
                        if (children.gameObject.GetComponent<VideoPlayer>().isPaused)
                        {
                            children.gameObject.GetComponent<VideoPlayer>().Play();
                            return;
                        }

                        if (children.gameObject.GetComponent<VideoPlayer>().isPlaying)
                        {
                            children.gameObject.GetComponent<VideoPlayer>().Pause();
                            return;
                        }
                    }
                }

            }

        

           

        }
    }





}
