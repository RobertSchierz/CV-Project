using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panellinkopener : MonoBehaviour
{
   public void openlink(string link)
    {
        if (link != "")
        {

           // Application.OpenURL(link);
            Application.ExternalEval("window.open( '"+ link +"' );");
        }
       
    }
}
 