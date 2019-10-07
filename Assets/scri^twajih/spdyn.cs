using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class spdyn : MonoBehaviour {
   public GameObject sp;
    // Use this for initialization
    // public string url = @"C:\img.png";
    public TextMeshPro txxt;
    Texture2D tex;
    Sprite spp;

 
    /*
        tex = Resources.Load(@"C:\img.png") as Texture2D;
        GameObject rawImage = GameObject.Find("RawImage");
        rawImage.GetComponent<RawImage>().texture = tex;
        Debug.Log("yes");
        */
        IEnumerator Start()
        {
            WWW www = new WWW("file:///c://WIYM//logo//img.png");
            while (!www.isDone)
                yield return null;
            GameObject image = GameObject.Find("RawImage1");
        
            image.GetComponent<RawImage>().texture = www.texture;
       

    }
    // Update is called once per frame
    void Update () {
		
	}
}
