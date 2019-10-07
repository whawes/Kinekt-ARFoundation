using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class displaytxt : MonoBehaviour {
    public GameObject gg;
  public TextMeshPro Bulle_txtt;

    // Use this for initialization
    private void Start()
    {
       
    }
    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(1);
      
        gg.transform.Find("Head/bubble_02/mods/cloud_centrale_mod/TextMeshPro").gameObject.SetActive(true);

          //  GameObject Bulle_txt = gg.transform.Find("Head/bulle+ modif/bubble_01_idle/mods/cloud_centrale_mod/TextMeshPro").gameObject;

           }


    int i = 1;
    private void Update()
    {
        // gb= gg.transform.Find("Head").gameObject;
if (gg.transform.Find("Head").gameObject.activeSelf)
        { StartCoroutine(Example()); }
        else { gg.transform.Find("Head/bubble_02/mods/cloud_centrale_mod/TextMeshPro").gameObject.SetActive(false); }
                
                
                // Debug.Log(gg.transform.GetChild(3).gameObject.name) ;
     /*   if (gg.transform.childCount > 2)
        {
            if (!gg.transform.GetChild(2).gameObject.activeSelf)
            {


              //  gg.transform.Find("Head/bulle+ modif/bubble_01_idle/mods/cloud_centrale_mod/TextMeshPro").gameObject.SetActive(false);
                //gg.transform.Find("Head/bubble_02/mods/cloud_centrale_mod/TextMeshPro").gameObject.SetActive(false);
                gg.transform.Find("Head/bubble_02/mods/cloud_centrale_mod/TextMeshPro").gameObject.SetActive(false);


               // Debug.Log("tt found");
                i = 0;


            }
            else
            {
                StartCoroutine(Example());
                
            }
           
        }*/
    }
}
