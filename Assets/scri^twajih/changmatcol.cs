using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class changmatcol : MonoBehaviour {
    public GameObject aa;
    public GameObject bb;
    public GameObject cc;
    



    Animator animation;


 //   Renderer rendcub;
    Renderer renda; Renderer rendb;
    Renderer rendc;
    // Use this for initialization
    void Start () {
      //  changecol();

    }
    public void changecol()
    {
        Debug.Log(textcub.coo);
        rendc = cc.GetComponent<Renderer>();
           renda = aa.GetComponent<Renderer>();
         rendb = bb.GetComponent<Renderer>();
        
      /*   Color myColor = new Color();
       ColorUtility.TryParseHtmlString(textcub.coo, out myColor);
        
    */

         renda.material.color = textcub.coo;
         rendb.material.color = textcub.coo;
         rendc.material.color = textcub.coo;
   
    }
    // Update is called once per frame
    void Update () {
    //    changecol();

    }
}
