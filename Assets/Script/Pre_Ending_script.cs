using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Pre_Ending_script : MonoBehaviour, IPointerDownHandler
{
    //public int count;
    public GameObject SongFirst;
    public GameObject SongSecond;
    public GameObject SongThird;
    public GameObject BoyFirst;
    public GameObject BoySecond;
    public GameObject PinkFlower;
    public GameObject WhiteFlower;
    public GameObject Song;
    public GameObject Boy;

    void Start()
    {
        //송이 첫번째 대화
        SongFirst.SetActive(true);
        SongSecond.SetActive(false);
        SongThird.SetActive(false);
        BoyFirst.SetActive(false);
        BoySecond.SetActive(false);
        PinkFlower.SetActive(true);
        WhiteFlower.SetActive(false);
        Song.SetActive(true);
        Boy.SetActive(false);
    }

    public void OnPointerDown(PointerEventData data)
    {

        if (SongFirst.activeSelf == true)
        {
            //남자애 첫번째 대화
            Debug.Log("c1");
            SongFirst.SetActive(false);
            SongSecond.SetActive(false);
            SongThird.SetActive(false);
            BoyFirst.SetActive(true);
            BoySecond.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Boy.SetActive(true);
        }
        else if (BoyFirst.activeSelf == true)
        {
            //송이 두번째 대화
            Debug.Log("c2");
            BoyFirst.SetActive(false);
            SongSecond.SetActive(true);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            Boy.SetActive(false);
            SongFirst.SetActive(false);
            SongThird.SetActive(false);
            BoySecond.SetActive(false);
        }
        else if (SongSecond.activeSelf == true)
        {
            //남자애 두번째 대화
            Debug.Log("c3");
            SongSecond.SetActive(false);
            BoySecond.SetActive(true);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Boy.SetActive(true);
            SongFirst.SetActive(false);
            SongThird.SetActive(false);
            BoyFirst.SetActive(false);
        }
        else if (BoySecond.activeSelf == true)
        {
            //송이 세번째 대화
            Debug.Log("c4");
            BoySecond.SetActive(false);
            SongThird.SetActive(true);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            Boy.SetActive(false);
            SongFirst.SetActive(false);
            SongSecond.SetActive(false);
            BoyFirst.SetActive(false);
        }
        else if (SongThird.activeSelf == true)
        {
            //다음씬으로
            Debug.Log("c5");
            SceneManager.LoadScene("Home");
        }
    }
}