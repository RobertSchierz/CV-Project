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


    private void Update()
    {
        if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.entry)
        {
            videoPlayer.Stop();
        }
    }


    public void stopthevideo()
    {

    }

    public void playthevideo(string url)
    {
  
        videoPlayer.url = url;
        videoPlayer.waitForFirstFrame = true;
        videoPlayer.Prepare();

        //StartCoroutine(LoadfirstFrame());
        //  videoPlayer.sendFrameReadyEvents = true;
        //  videoPlayer.frameReady += OnNewFrame;

          //StartCoroutine(ChangeTexture());

      

        if (videocontrollcanvas != null)
        {
            LeanTween.alphaCanvas(videocontrollcanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
            videocontrollcanvas.GetComponent<CanvasGroup>().interactable = true;
            videocontrollcanvas.GetComponent<CanvasGroup>().blocksRaycasts = true;
        }

    
        
    

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
