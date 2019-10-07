using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lodsp : MonoBehaviour {
   // Sprite spritee;
    public GameObject gb;
    public string nom;



    IEnumerator Start()
    {
        WWW www = new WWW("file:///c://WIYM//bulle//" + nom);
           
        while (!www.isDone)
            yield return null;

        gameObject.GetComponent<SpriteRenderer>().sprite =Sprite.Create(www.texture, new Rect(0, 0, 960, 516), new Vector2(0.5f, 0.5f));
        Debug.Log("ok");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
