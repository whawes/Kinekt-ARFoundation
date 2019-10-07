using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using System.Threading;

public class colbulle1 : MonoBehaviour {
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
    List <string> B = new List<string>();
    List <string> C = new List<string>();
    List <string>D = new List<string>();
    List <string> E = new List<string>();
   
    // Use this for initialization
   
        void Start () {
        rendelt_1 = bulleelt_1.GetComponent<Renderer>();
        rendelt_2 = bulleelt_2.GetComponent<Renderer>();
        rendelt_3 = bulleelt_3.GetComponent<Renderer>();
        rendelt_4 = bulleelt_4.GetComponent<Renderer>();
        //InvokeRepeating("coleur", 3.0f, 5f);
        InvokeRepeating("testid", 0.0f, 1f);


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

            }
        }
        

    }
    
    public String oldid;
    public void testid()
    { oldid = textcube.id; }

    // Update is called once per frame

    void Update () {
        Color Bulle_Color = new Color();
        ColorUtility.TryParseHtmlString(textcube.bulle_color, out Bulle_Color);

        //Thread.Sleep(1000);
        if (textcube.id !=id)
         { //Debug.Log(A[0]);
            id = textcube.id;
        
           
             System.Random rand = new System.Random(); 
            Debug.Log(A[0]);
          
               switch (id)
             {

                case "1":
                    int i = rand.Next(A.Count);
                    if (textcube.idres.Count == A.Count)
                    {
                        Debug.Log(textcube.idres.Count);
                        txxt.text = A[rand.Next(A.Count)].ToString();
                        Debug.Log("randommm");
                        }
                    else
                    {
                        if (textcube.idres.Contains(i))
                        {
                            Debug.Log("id existe");
                            do { i = rand.Next(A.Count); } while (!textcube.idres.Contains(i));
                            textcube.idres.Add(i);
                            txxt.text = A[i].ToString();
                            Debug.Log("id new");
                        }
                        else
                        {
                            textcube.idres.Add(i); Debug.Log("id new");
                            txxt.text = A[i].ToString();
                        }

                       
                    }
                    break;
                /*   if (int.Parse(transform.root.gameObject.name.ToString()) <= A.Count)
                     {
                         Debug.Log(int.Parse(transform.root.gameObject.name.ToString()));
                            Debug.Log(A[int.Parse(transform.root.gameObject.name.ToString())].ToString());
                         txxt.text = A[int.Parse(transform.root.gameObject.name.ToString())].ToString();
                     }
                     else { txxt.text = A[rand.Next(A.Count)].ToString(); break; }*/


                case "2":
                    i = rand.Next(B.Count);
                    if (textcube.idre2.Count == B.Count)
                    {

                        txxt.text = B[rand.Next(B.Count)].ToString();
                        Debug.Log("randommm");
                    }
                    else
                    {
                        if (textcube.idre2.Contains(i))
                        {
                            Debug.Log("id existe");
                            do { i = rand.Next(B.Count); } while (!textcube.idre2.Contains(i));
                            textcube.idre2.Add(i);
                            txxt.text = B[i].ToString();
                            Debug.Log("id new");
                        }
                        else
                        {
                            textcube.idre2.Add(i); Debug.Log("id new");
                            txxt.text = B[i].ToString();
                        }


                    }
                    break;
                /*if (int.Parse(transform.root.gameObject.name.ToString()) <= B.Count)
                { txxt.text = B[int.Parse(transform.root.gameObject.name.ToString())].ToString(); }

                else
                { txxt.text = B[rand.Next(B.Count)].ToString(); }
                break;*/

                case "3":
                    i = rand.Next(C.Count);
                    if (textcube.idre3.Count == C.Count)
                    {

                        txxt.text = C[rand.Next(C.Count)].ToString();
                        Debug.Log("randommm");
                    }
                    else
                    {
                        if (textcube.idre3.Contains(i))
                        {
                            Debug.Log("id existe");
                            do { i = rand.Next(C.Count); } while (!textcube.idre3.Contains(i));
                            textcube.idre3.Add(i);
                            txxt.text =C[i].ToString();
                            Debug.Log("id new");
                        }
                        else
                        {
                            textcube.idre3.Add(i); Debug.Log("id new");
                            txxt.text = C[i].ToString();
                        }


                    }
                    break;

                /* if (int.Parse(transform.root.gameObject.name.ToString()) <= C.Count)
                 { txxt.text = C[int.Parse(transform.root.gameObject.name.ToString())].ToString(); }
                 else
                 { txxt.text = C[rand.Next(C.Count)].ToString(); }
                 break;*/
                case "4":
                    i = rand.Next(D.Count);
                    if (textcube.idre4.Count == D.Count)
                    {

                        txxt.text = D[rand.Next(C.Count)].ToString();
                        Debug.Log("randommm");
                    }
                    else
                    {
                        if (textcube.idre4.Contains(i))
                        {
                            Debug.Log("id existe");
                            do { i = rand.Next(D.Count); } while (!textcube.idre4.Contains(i));
                            textcube.idre4.Add(i);
                            txxt.text = D[i].ToString();
                            Debug.Log("id new");
                        }
                        else
                        {
                            textcube.idre4.Add(i); Debug.Log("id new");
                            txxt.text = D[i].ToString();
                        }


                    }
                    break;
                /*  if (int.Parse(transform.root.gameObject.name.ToString()) <= D.Count)
                  { txxt.text = D[int.Parse(transform.root.gameObject.name.ToString())].ToString(); }
                  else
                  { txxt.text = D[rand.Next(D.Count)].ToString(); }
                  break;*/
               
          
                case "5":
                    i = rand.Next(E.Count);
                    if (textcube.idre5.Count == E.Count)
                    {

                        txxt.text = E[rand.Next(E.Count)].ToString();
                        Debug.Log("randommm");
                    }
                    else
                    {
                        if (textcube.idre5.Contains(i))
                        {
                            Debug.Log("id existe");
                            do { i = rand.Next(E.Count); } while (!textcube.idre5.Contains(i));
                            textcube.idre5.Add(i);
                            txxt.text = E[i].ToString();
                            Debug.Log("id new");
                        }
                        else
                        {
                            textcube.idre5.Add(i); Debug.Log("id new");
                            txxt.text = E[i].ToString();
                        }


                    }
                    break;


                    /* if (int.Parse(transform.root.gameObject.name.ToString()) <= E.Count)
                    { txxt.text = E[int.Parse(transform.root.gameObject.name.ToString())].ToString(); }
                    else
                    { txxt.text = E[rand.Next(E.Count)].ToString(); }


                    break;*/
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
