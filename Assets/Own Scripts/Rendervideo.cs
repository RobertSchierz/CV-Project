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


    void Start()
    {
        
    }

    public void playthevideo(string url)
    {
        videoPlayer.url = url;
        if (videocontrollcanvas != null)
        {
            LeanTween.alphaCanvas(videocontrollcanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
            videocontrollcanvas.GetComponent<CanvasGroup>().interactable = true;
            videocontrollcanvas.GetComponent<CanvasGroup>().blocksRaycasts = true;
        }

        StartCoroutine(Play());

    }

    IEnumerator Play()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(0.5f);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        //rawImage.texture = videoPlayer.texture;

        if (videoplane != null)
        {
            videoplane.GetComponent<MeshRenderer>().enabled = true;
        }
        videoPlayer.Play();


    }
}
