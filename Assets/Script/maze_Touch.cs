using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class maze_Touch : MonoBehaviour, IPointerDownHandler
{
    public int icon_st;
    public GameObject oly;
    public void OnPointerDown(PointerEventData data)
    {
        switch (icon_st)
        {
            case 0:
                Debug.Log("올림픽");
                oly.SetActive(false);
                break;
            case 1:
                Debug.Log("c2");
                SceneManager.LoadScene("Stage4_FirstEnd");
                break;
            case 2:
                Debug.Log("c3");
                SceneManager.LoadScene("Stage4_FirstQuestion");
                break;
            case 3:
                Debug.Log("c4");
                SceneManager.LoadScene("Stage4_SecondHint");
                break;
        }
    }
}
