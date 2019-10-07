using UnityEngine;
using System.Collections;
using System;

public class DataInserter : MonoBehaviour
{

    public string inputUserName;
    public string inputPassword;
    public string inputEmail;

    string CreateUserURL = "http://mota.takolor.net/insert.php";

    // Use this for initialization
    void Start()
    {
        Debug.Log(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
    }

  

    public void CreateUser(string id,string eventt)
    {
        WWWForm form = new WWWForm();
        form.AddField("timestamp", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
        form.AddField("session", "-");
        form.AddField("user", id);
        form.AddField("project", "WYIM");
        form.AddField("device", "Heavent_1");
        form.AddField("event", eventt);
        form.AddField("value", "-");

        WWW www = new WWW(CreateUserURL, form);
    }
}