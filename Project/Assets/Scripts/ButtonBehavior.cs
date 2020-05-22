using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    private int count = 0;
    public GameObject textbox;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = textbox.GetComponent<TextMeshProUGUI>();
        Debug.Log(text.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsClicked() {
        count++;
        text.text = "I was clicked " + count + " times.";
        Application.OpenURL("http://unity3d.com/");
    }
}
