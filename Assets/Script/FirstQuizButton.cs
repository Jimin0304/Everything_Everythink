using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstQuizButton : MonoBehaviour
{
    public BtnType currentType;
    public GameObject O;
    //public GameObject X;
    public GameObject FirstTalk;
    public GameObject WrongTalk;

    void Start()
    {
        O.SetActive(false);
        //X.SetActive(false);
        FirstTalk.SetActive(true);
        WrongTalk.SetActive(false);
    }

    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BtnType.Correct:
                Debug.Log("정답입니다.");
                O.SetActive(true);
                break;
            case BtnType.Firstwrong:
                Debug.Log("틀렸습니다.");
                // X.SetActive(true);
                FirstTalk.SetActive(false);
                WrongTalk.SetActive(true);
                break;
            case BtnType.Secondwrong:
                Debug.Log("틀렸습니다.");
                //  X.SetActive(true);
                FirstTalk.SetActive(false);
                WrongTalk.SetActive(true);
                break;
            case BtnType.Hint:
                Debug.Log("힌트");
                break;
            case BtnType.Exit:
                Debug.Log("힌트나가기");
                break;
        }
    }
}
