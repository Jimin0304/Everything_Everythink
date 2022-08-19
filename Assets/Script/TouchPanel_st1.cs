using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchPanel_st1 : MonoBehaviour, IPointerDownHandler
{
    public int count;
   public void OnPointerDown(PointerEventData data)
    {
        switch (count)
        {
            case 0:
               
                Debug.Log("c1");
                Application.LoadLevel("Stage1_quiz2");
                break;
            case 1:
               
                Debug.Log("c2");
                Application.LoadLevel("Stage1_quiz3");
                break;
            case 2:
                
                Debug.Log("c3");
                Application.LoadLevel("Stage1_quiz4");
                break;
            case 3:
               
                Debug.Log("c4");
                Application.LoadLevel("Stage1_quiz5");
                break;
            case 4:

                Debug.Log("c5");
                Application.LoadLevel("Stage1_quiz1");
                break;
            case 5:

                Debug.Log("c6");
                Application.LoadLevel("Stage1_End_stage1");
                break;
            case 6:

                Debug.Log("c7");
                Application.LoadLevel("Home");
                break;
        }
    }
}
