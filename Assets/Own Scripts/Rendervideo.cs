using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Rendervideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject videocontrollcanvas;
    public GameObject videoplane;
    public GameObject displayui;

    public bool isgame;
    public bool ismodell;
    public bool isandroid;

    public GameObject progressobject;


    private void Update()
    {
     
        if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.entry)
        {
            videoPlayer.Stop();
            videoplane.GetComponent<MeshRenderer>().enabled = false;
        }

      /*  if (!videoPlayer.isPlaying)
        {
            videoplane.GetComponent<MeshRenderer>().enabled = false;
        }*/
    }


    public void stopthevideo()
    {

    }

    public void playthevideo()
    {
        progressobject.GetComponent<VideoProgressBar>().setVideoPlayer(videoPlayer);
        videoPlayer.Prepare();

        //StartCoroutine(LoadfirstFrame());
        //  videoPlayer.sendFrameReadyEvents = true;
        //  videoPlayer.frameReady += OnNewFrame;

        //StartCoroutine(ChangeTexture());



        if (isgame)
        {
            displayui.GetComponent<Displayuicontroller>().playVideoOfGame();
        }

        if (ismodell)
        {
            displayui.GetComponent<Displayuicontroller>().playVideoOfModell();
        }

        if (isandroid)
        {
            displayui.GetComponent<Displayuicontroller>().playVideoOfLernapp();
        }

        if (videocontrollcanvas != null)
        {
            LeanTween.alphaCanvas(videocontrollcanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
            videocontrollcanvas.GetComponent<CanvasGroup>().interactable = true;
            videocontrollcanvas.GetComponent<CanvasGroup>().blocksRaycasts = true;
        }

        videoplane.GetComponent<MeshRenderer>().enabled = true;

     


    }

    void OnNewFrame(VideoPlayer source, long frameIdx)
    {
        Texture2D videoFrame = (Texture2D)source.texture;
        videoplane.GetComponent<MeshRenderer>().materials[0].SetTexture("VideoRenderTexture",videoFrame);
    }

    IEnumerator ChangeTexture()
    {

        WaitForSeconds waitForSeconds = new WaitForSeconds(0.5f);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }

        videoPlayer.time = 0;
        videoPlayer.Play();
        videoplane.GetComponent<MeshRenderer>().materials[0].SetTexture("VideoRenderTexture", videoPlayer.texture);
        videoPlayer.Pause();

        videoplane.GetComponent<MeshRenderer>().enabled = true;

    }

    IEnumerator LoadfirstFrame()
    {
        
        WaitForSeconds waitForSeconds = new WaitForSeconds(0.5f);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        //rawImage.texture = videoPlayer.texture;

        //videoplane.GetComponent<MeshRenderer>().materials[0].SetTexture("VideoRenderTexture", videoPlayer.texture);
        videoPlayer.Pause();
        videoplane.GetComponent<MeshRenderer>().enabled = true;


    }
}
