using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chairanimation : MonoBehaviour
{
    public GameObject maincamera;
    public bool animationDone = false;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (maincamera != null)
        {
            if (!animationDone)
            {
                if (Vector3.Distance(maincamera.transform.position, transform.position) <= 4.5f)
                {
                    if (gameObject.GetComponent<Animator>() != null)
                    {
                        if (!gameObject.GetComponent<Animator>().GetBool("Chairspin"))
                        {
                            gameObject.GetComponent<Animator>().SetBool("Chairspin", true);
                        }
                    }
                }
            }
                
            

        }
    }
}
