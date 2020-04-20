using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ichuicontroller : MonoBehaviour
{

    public GameObject earth;
    public Animator earthanimator;
    
    public void startauslandsanimation()
    {
        if (earth != null)
        {
            if (earthanimator != null)
            {
                earthanimator.SetBool("startearth", true);
            }
            earth.GetComponent<MeshRenderer>().enabled = true;
            LeanTween.moveLocalY(earth, 1, 2).setEaseInOutBack();
        }
    }
}
