using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displayuicontroller : MonoBehaviour
{

    public GameObject videoplayer;
    public GameObject rightpccanvas;
    public GameObject leftpccanvas;
    public GameObject FPZinfocanvas;


    private void Update()
    {
        if (GameObject.Find("Mastercontroller").GetComponent<Mastercontroller>().state == States.entry)
        {
            LeanTween.alphaCanvas(leftpccanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            LeanTween.alphaCanvas(rightpccanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            LeanTween.alphaCanvas(FPZinfocanvas.GetComponent<CanvasGroup>(), 0, 0.5f);
            leftpccanvas.GetComponent<CanvasGroup>().interactable = false;
        }
    }

    public void playVideoOfGame()
    {
        LeanTween.alphaCanvas(FPZinfocanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
        videoplayer.GetComponent<Rendervideo>().playthevideo("http://beuthdbs.bplaced.net/test/videos/FPZ.mp4");
        if (rightpccanvas != null)
        {
            LeanTween.alphaCanvas(rightpccanvas.GetComponent<CanvasGroup>(), 1, 0.5f);
        }
    }
   
   
    public void easerightmonitorcanvas()
    {
       
        if (rightpccanvas != null)
        {
           
            LeanTween.alphaCanvas(rightpccanvas.GetComponent<CanvasGroup>(), 1, 0.5f);

        }
    }

 
}
