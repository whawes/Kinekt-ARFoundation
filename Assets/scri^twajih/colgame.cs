using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine;
using System;
using System.Text;

public class colgame : MonoBehaviour {
    public GameObject bulleelt_1;
    public GameObject bulleelt_2;
    public GameObject bulleelt_3;
    public GameObject bulleelt_4;
    Renderer rendelt_1;
    Renderer rendelt_2;
    Renderer rendelt_3;
    Renderer rendelt_4;

    String txt_color;
    String bulle_color;
    String line_Colors;

    public TextMeshPro Bulle_txt;
    DateTime date1;
    private string ch;

    // Use this for initialization
    void Start () {
        string[] all = File.ReadAllLines(@"C:\WIYM\color.txt"); //read color file
        System.Random rand = new System.Random(); // random color

        line_Colors = all[rand.Next(all.Length)].ToString();

        char[] splitchar = { '/' };
        string[] words = line_Colors.Split(splitchar);
        txt_color = words[1];
        bulle_color = words[0];


        //attribuer la couleur pour la bulle
        rendelt_1 = bulleelt_1.GetComponent<Renderer>();
        rendelt_2 = bulleelt_2.GetComponent<Renderer>();
        rendelt_3 = bulleelt_3.GetComponent<Renderer>();
        rendelt_4 = bulleelt_4.GetComponent<Renderer>();

        Color Bulle_Color = new Color();
        ColorUtility.TryParseHtmlString(bulle_color, out Bulle_Color);

        rendelt_1.material.color = Bulle_Color;
        rendelt_2.material.color = Bulle_Color;
        rendelt_3.material.color = Bulle_Color;
        rendelt_4.material.color = Bulle_Color;

        // changer color text 

        Color Txt_Color = new Color();
        ColorUtility.TryParseHtmlString(txt_color, out Txt_Color);
        Bulle_txt.color = Txt_Color;

        //random text with date//
        DateTime today = DateTime.Today;
        Debug.Log(today);
       

        string[] alldate;
        alldate = File.ReadAllLines(@"C:\WIYM\date.txt"); //read date file

        DateTime myDate = DateTime.ParseExact(alldate[0], "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);

        Debug.Log(myDate);
        int result = DateTime.Compare(myDate, today);
        Debug.Log(result);
        string[] allLines;
        if (result > 0) // get txt file selon date
        {
            allLines = File.ReadAllLines(@"C:\WIYM\text\fr.txt");
        }
        else { allLines = File.ReadAllLines(@"C:\WIYM\text\ang.txt"); }
        System.Random ran = new System.Random();
        int c = ran.Next(allLines.Length);
          ch = allLines[c];


        Debug.Log(ch.Length);
        using (System.IO.StreamWriter file =
         new System.IO.StreamWriter(@"C:\WIYM\out.txt", true))
        {

            file.WriteLine(c.ToString());



        }

        Bulle_txt.text = ch;
      
       


    }

    // Update is called once per frame
    void Update () {
		
	}
}
