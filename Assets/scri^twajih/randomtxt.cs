using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using System;

public class randomtxt : MonoBehaviour {
    public TextMeshPro txxt;

    // Use this for initialization
    string ch;
    DateTime date1;
    public void changetxt()
    {
        DateTime today = DateTime.Today;
        Debug.Log(today);
        DateTime date2 = new DateTime(2020, 8, 1, 0, 0, 0);
          int result = DateTime.Compare(date2, date1);
        Debug.Log(result);
        string[] allLines;
        if (result > 0)
        {
             allLines = File.ReadAllLines(@"C:\WIYM\text\fr.txt");
        }
        else {  allLines = File.ReadAllLines(@"C:\WIYM\text\ang.txt"); }
        System.Random ran = new System.Random();
        ch = allLines[ran.Next(allLines.Length)];
        Debug.Log(ch.Length);
        if (ch.Length > 40)
        {
            txxt.text = ch.Substring(0, 39);
            //tt.color = Color.red;
        }
        else { txxt.text = ch; }
    }
  
    void Start () {


        changetxt();





        /*
        
      //  rendcub.material.color = myColor;
        /*   




            /*  string[] allLine = File.ReadAllLines(@"C:\WIYM\ann.txt");
            System.Random rann = new System.Random();
            Debug.Log(allLine[rann.Next(allLine.Length)].ToString());
            animation.Play(allLine[rann.Next(allLine.Length)].ToString());



            string[] all = File.ReadAllLines(@"C:\WIYM\color.txt");
            System.Random rand = new System.Random();
            Debug.Log(all[rand.Next(all.Length)].ToString());




            rend = gameObject.GetComponent<Renderer>();
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString(all[rand.Next(all.Length)].ToString(), out myColor);


            rend.material.color = myColor;*/
    }

    // Update is called once per frame
    void Update () {
      
    }
}
