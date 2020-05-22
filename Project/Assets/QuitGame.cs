using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//Very simple script to quit the game
public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
}
