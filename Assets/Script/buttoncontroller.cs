using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttoncontroller : MonoBehaviour
{
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject btn4;
    public GameObject btn5;
    public GameObject song;
    public GameObject Song1;
    public GameObject Song2;
    public GameObject Song3;
    public GameObject Song4;
    public GameObject pip1;
    public GameObject pip2;
    public GameObject pip3;
    public GameObject line;
   
    public static int now_status;

    public BTnType currentType;

    private void Update()
    {
        if (now_status == 0)
        {
            line.SetActive(true);
            song.SetActive(true);
        }
        else if (now_status == 1)
        {
            line.SetActive(true);
            Song1.SetActive(true);
        }
        else if (now_status == 2)
        {
            line.SetActive(true);
            Song2.SetActive(true);
        }
        else if (now_status == 3)
        {
            line.SetActive(false);
            Song3.SetActive(true);
        }
        else if (now_status == 4)
        {
            line.SetActive(false);
            Song4.SetActive(true);
        }
    }
    public void stagecheck()
    {
        if (now_status == 0)
        {
            now_status += 1;
            line.SetActive(true);
            Application.LoadLevel("Stage1_HowTo");
        }
        else if(now_status == 1)
        {
           // now_status = 1;
            now_status += 1;
            line.SetActive(true);
            Application.LoadLevel("Scene4");
        }
        else if(now_status == 2)
        {
           // now_status = 2;
            now_status += 1;
            line.SetActive(true);
            Application.LoadLevel("Scene5");
        }
        else if (now_status == 3)
        {
           // now_status = 3;
            now_status += 1;
            line.SetActive(false);
            Application.LoadLevel("Scene6");
        }
        else if (now_status == 4)
        {
            line.SetActive(false);
            Application.LoadLevel("Grandma");
        }
    }

    public void OnClickButton()
    {
        switch (currentType)
        {
            case BTnType.stage1_button:

                now_status = 0;
                Debug.Log("첫 버튼 이프문" + now_status);
                song.SetActive(false);
                Song1.SetActive(true);
                Song2.SetActive(false);
                Song3.SetActive(false);
                Song4.SetActive(false);
                stagecheck();
                Debug.Log("b1");
                break;

            case BTnType.stage2_button:
                if (now_status != 0)
                {
                    now_status = 1;
                    Debug.Log("두번 버튼 이프문" + now_status);
                    song.SetActive(false);
                    Song1.SetActive(false);
                    Song2.SetActive(true);
                    Song3.SetActive(false);
                    Song4.SetActive(false);
                    stagecheck();
                    Debug.Log("b2");
                }
                break;

            case BTnType.stage3_button:
                if (now_status != 0 && now_status != 1)
                {
                    now_status = 2;
                    Debug.Log("세번 버튼 이프문" + now_status);
                    song.SetActive(false);
                    Song1.SetActive(false);
                    Song4.SetActive(false);
                    Song2.SetActive(false);
                    Song3.SetActive(true);
                    stagecheck();
                    Debug.Log("b3");
                }
                break;

            case BTnType.stage4_button:
                if (now_status != 0 && now_status != 1 && now_status != 2)
                {
                    now_status = 3;
                    Debug.Log("네번 버튼 이프문" + now_status);
                    song.SetActive(false);
                    Song1.SetActive(false);
                    Song2.SetActive(false);
                    Song3.SetActive(false);
                    Song4.SetActive(true);
                    stagecheck();
                    Debug.Log("b4");
                }
                break;
            case BTnType.stage5_button:
                if (now_status != 0 && now_status != 1 && now_status != 2 && now_status !=3)
                {
                    now_status = 4;
                    Debug.Log("다섯번 버튼 이프문" + now_status);
                    song.SetActive(false);
                    Song1.SetActive(false);
                    Song2.SetActive(false);
                    Song3.SetActive(false);
                    Song4.SetActive(true);
                    stagecheck();
                    Debug.Log("b5");
                }
                break;
        }
    }
}
