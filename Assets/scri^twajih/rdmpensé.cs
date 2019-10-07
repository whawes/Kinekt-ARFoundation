using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rdmpensé : MonoBehaviour {
    public GameObject gb1; public GameObject gb2;
    public GameObject gb3;

    //
    // Use this for initialization
    void Start () {
        int bull = Random.Range(1, 3);
        Debug.Log(bull.ToString());
        switch (bull)
        {   case 1: gb1.SetActive(true);break;
            case 2: gb2.SetActive(true); break;
            default: gb3.SetActive(true);break;
        }
      //  case 2:
       // case 3:
        //case 4:

        }

        // Update is called once per frame
        void Update () {
		
	}
   
}
