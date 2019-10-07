using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class textcube : MonoBehaviour {
    public GameObject bg;
    string line_Colors;
    public string txt;
    public static string bulle_color;
    public static string id;
    public GameObject cub;
    Renderer rendcub;
    public TextMeshPro txxt;
    // Use this for initialization
    public static List<int> idres = new List<int>();
    public static List<int> idre2 = new List<int>();
    public static List<int> idre3 = new List<int>();
    public static List<int> idre4 = new List<int>();
    public static List<int> idre5 = new List<int>();
    void Start () {
        rendcub = cub.GetComponent<Renderer>();


        InvokeRepeating("updatecol", 0.0f, 10f);

        

    }
    int i = 0;
	public void updatecol()
    {

        string[] all = File.ReadAllLines(@"C:\WIYM\text\ang.txt"); //read color file
        System.Random rand = new System.Random(); // random color

        line_Colors = all[i].ToString();

        char[] splitchar = { '/' };
        Debug.Log(line_Colors);
        string[] words = line_Colors.Split(splitchar);
        id = words[0];
        txt = words[2];
        bulle_color = words[1];


        Color Bulle_Color = new Color();
        ColorUtility.TryParseHtmlString(bulle_color, out Bulle_Color);


        rendcub.material.color = Bulle_Color;
        txxt.text = txt;
        i++;
        if (i == all.Length) { i = 0; }
       

    }
    // Update is called once per frame
    void Update () {
		
	}
}
