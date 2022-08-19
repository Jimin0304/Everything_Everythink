using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum BTnType
{
    Quiz1_Dialog,
    Quiz2_Dialog,
    Quiz3_Dialog,
    Quiz4_Dialog,
    stage1_button,
    stage2_button,
    stage3_button,
    stage4_button,
    stage5_button
}
public class Quiz1_button : MonoBehaviour
{
    void Start()
    {
        Quiz1_Next.SetActive(false);
    }
    public GameObject Quiz1_Next;
    public GameObject main_Text;
    public GameObject ans2;
    public GameObject ans3;
    public GameObject ans4;
    public BTnType currentType;
    public int nowScene;
    public void OnClickButton()
    {
        switch (currentType)
        {
            case BTnType.Quiz1_Dialog:
                main_Text.SetActive(true);
                ans2.SetActive(false);
                ans3.SetActive(false);
                ans4.SetActive(false);
                Debug.Log("정답입니당");
                Quiz1_Next.SetActive(true);
                //씬 넘기기
                break;
            case BTnType.Quiz2_Dialog:
                main_Text.SetActive(false);
                ans2.SetActive(true);
                ans3.SetActive(false);
                ans4.SetActive(false);
                Debug.Log("오답입니당");
                break;
            case BTnType.Quiz3_Dialog:
                main_Text.SetActive(false);
                ans2.SetActive(false);
                ans3.SetActive(true);
                ans4.SetActive(false);
                Debug.Log("오답입니당");
                break;
            case BTnType.Quiz4_Dialog:
                main_Text.SetActive(false);
                ans2.SetActive(false);
                ans3.SetActive(false);
                ans4.SetActive(true);
                Debug.Log("오답입니당");
                break;

        }
    }
}
