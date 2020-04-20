using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Rendervideo : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoPlayer;


    void Start()
    {
        
    }

    public void playthevideo(string url)
    {
        videoPlayer.url = url;
        StartCoroutine(Play());
    }

    IEnumerator Play()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(5);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();

    }
}
