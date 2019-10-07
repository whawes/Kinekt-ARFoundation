using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using System.Threading;

public class colbulle : MonoBehaviour
{
    public GameObject bulleelt_1;
    public GameObject bulleelt_2;
    public GameObject bulleelt_3;
    public GameObject bulleelt_4;
    Renderer rendelt_1;
    Renderer rendelt_2;
    Renderer rendelt_3;
    Renderer rendelt_4;
    public TextMeshPro txxt;
    string id = "0";
    List<string> A = new List<string>();
    List<string> B = new List<string>();
    List<string> C = new List<string>();
    List<string> D = new List<string>();
    List<string> E = new List<string>();
    List<string> F = new List<string>();
    // Use this for initialization

    void Start()
    {
        rendelt_1 = bulleelt_1.GetComponent<Renderer>();
        rendelt_2 = bulleelt_2.GetComponent<Renderer>();
        rendelt_3 = bulleelt_3.GetComponent<Renderer>();
        rendelt_4 = bulleelt_4.GetComponent<Renderer>();
        //InvokeRepeating("coleur", 3.0f, 5f);



        string[] all = File.ReadAllLines(@"C:\WIYM\text\alltext.txt");
        for (int i = 0; i < all.Length; i++)
        {
            char[] splitchar = { '/' };
            string[] words = all[i].Split(splitchar);

            switch (words[0])
            {
                case "1":
                    A.Add(words[1]);
                    break;
                case "2":
                    B.Add(words[1]);
                    break;
                case "3":
                    C.Add(words[1]);
                    break;
                case "4":
                    D.Add(words[1]);
                    break;
                case "5":
                    E.Add(words[1]);
                    break;
                case "6":
                    F.Add(words[1]);
                    break;

            }
        }


    }


    // Update is called once per frame

    void Update()
    {
        Color Bulle_Color = new Color();
        ColorUtility.TryParseHtmlString(textcube.bulle_color, out Bulle_Color);

        //Thread.Sleep(1000);
        if (textcube.id != id)
        { //Debug.Log(A[0]);

            // Debug.Log(transform.root.gameObject.name);


            id = textcube.id;
            System.Random rand = new System.Random();


            switch (id)
            {

                case "1":

                    if (int.Parse(transform.root.gameObject.name.ToString()) <= A.Count)
                    {
                        Debug.Log(A[int.Parse(transform.root.gameObject.name.ToString())].ToString());
                        txxt.text = A[int.Parse(transform.root.gameObject.name.ToString())].ToString();
                    }
                    else { txxt.text = A[rand.Next(A.Count)].ToString(); break; }
                    break;

                case "2":
                    if (int.Parse(transform.root.gameObject.name.ToString()) <= B.Count)
                    { txxt.text = B[int.Parse(transform.root.gameObject.name.ToString())].ToString(); }

                    else
                    { txxt.text = B[rand.Next(B.Count)].ToString(); }
                    break;

                case "3":
                    if (int.Parse(transform.root.gameObject.name.ToString()) <= C.Count)
                    { txxt.text = C[int.Parse(transform.root.gameObject.name.ToString())].ToString(); }
                    else
                    { txxt.text = C[rand.Next(C.Count)].ToString(); }
                    break;
                case "4":
                    if (int.Parse(transform.root.gameObject.name.ToString()) <= D.Count)
                    { txxt.text = D[int.Parse(transform.root.gameObject.name.ToString())].ToString(); }
                    else
                    { txxt.text = D[rand.Next(D.Count)].ToString(); }
                    break;
                case "5":
                    if (int.Parse(transform.root.gameObject.name.ToString()) <= E.Count)
                    { txxt.text = E[int.Parse(transform.root.gameObject.name.ToString())].ToString(); }
                    else
                    { txxt.text = E[rand.Next(E.Count)].ToString(); }break;

                case "6":
                    if (int.Parse(transform.root.gameObject.name.ToString()) <= F.Count)
                    { txxt.text = F[int.Parse(transform.root.gameObject.name.ToString())].ToString(); }
                    else
                    { txxt.text = F[rand.Next(F.Count)].ToString(); }
                    break;
                    //  txxt.text = E[rand.Next(E.Count)].ToString(); break;

            }
        }

        // Debug.Log(textcube.bulle_color);
        rendelt_1.material.color = Bulle_Color;
        rendelt_2.material.color = Bulle_Color;
        rendelt_3.material.color = Bulle_Color;
        rendelt_4.material.color = Bulle_Color;

    }
}
