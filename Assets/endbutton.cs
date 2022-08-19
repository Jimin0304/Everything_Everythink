using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endbutton : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("종료");
        Application.Quit();
    }
}
