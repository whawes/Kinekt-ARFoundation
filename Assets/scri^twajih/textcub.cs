using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class textcub : MonoBehaviour {
    public TextMeshPro txxt;
    //string coo;
  public  static Color coo;

    // Use this for initialization
    void Start() {
        string[] all = File.ReadAllLines(@"C:\WIYM\color.txt");
        System.Random rand = new System.Random();
        Debug.Log(all[rand.Next(all.Length)].ToString());
        string cg= all[rand.Next(all.Length)].ToString();
        char[] splitchar = { '/' };
        string[] words =cg.Split(splitchar);
        Debug.Log(words[0]+" "+ words[1]);
        
       // col = words[0];
        //  rend = gameObject.GetComponent<Renderer>();
        Color myColor = new Color();
        ColorUtility.TryParseHtmlString(words[1], out myColor);
        txxt.color = myColor;

        Color col = new Color();
        ColorUtility.TryParseHtmlString(words[0], out col);
        coo = col;

    }
    /*public void change()
    {
        string[] all = File.ReadAllLines(@"C:\WIYM\color.txt");
        System.Random rand = new System.Random();
        Debug.Log(all[rand.Next(all.Length)].ToString());
        string[] words = rand.Next(all.Length).ToString().Split('/');
        foreach (string word in words)
        {
            Debug.Log(words[0]);
        }
        col = words[0];
      //  rend = gameObject.GetComponent<Renderer>();
        Color myColor = new Color();
        ColorUtility.TryParseHtmlString(words[1], out myColor);
        txxt.color = myColor;

        //rend.material.color = myColor;
        //  txxt.color = myColor;
        coo = myColor;
    }*/
    // Update is called once per frame
    void Update () {
		
	}
}
