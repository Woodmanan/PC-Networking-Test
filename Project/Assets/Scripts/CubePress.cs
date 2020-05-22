using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePress : MonoBehaviour
{
    public string URL = "https://unity.com/";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        // opens he given url in a new window
        Application.OpenURL(URL);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
