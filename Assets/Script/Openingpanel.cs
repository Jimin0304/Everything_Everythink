using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Openingpanel : MonoBehaviour, IPointerDownHandler
{
    //public int count;
    public GameObject Song1;
    public GameObject Song2;
    public GameObject Song3;
    public GameObject Song4;
    public GameObject Song5;
    public GameObject Grandpa1;
    public GameObject Grandpa2;
    public GameObject Grandpa3;
    public GameObject Grandpa4;
    public GameObject Opening;
    public GameObject PinkFlower;
    public GameObject WhiteFlower;
    public GameObject Songe;
    public GameObject Grandpa;
    public GameObject Nextbutton;

    void Start()
    {
        //배경 설명
        Opening.SetActive(true);
        Song1.SetActive(false);
        Song2.SetActive(false);
        Song3.SetActive(false);
        Song4.SetActive(false);
        Song5.SetActive(false);
        Grandpa1.SetActive(false);
        Grandpa2.SetActive(false);
        Grandpa3.SetActive(false);
        Grandpa4.SetActive(false);
        PinkFlower.SetActive(false);
        WhiteFlower.SetActive(false);
        Songe.SetActive(false);
        Grandpa.SetActive(false);
        Nextbutton.SetActive(false);
    }

    public void OnPointerDown(PointerEventData data)
    {

        if (Opening.activeSelf == true)
        {
            //송이 첫번째 대화
            Debug.Log("c1");
            Opening.SetActive(false);
            Song1.SetActive(true);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Songe.SetActive(true);
            Grandpa.SetActive(false);
            Song5.SetActive(false);
            Grandpa4.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Song1.activeSelf == true)
        {
            //할아버지 첫번째 대화
            Debug.Log("c2");
            Opening.SetActive(false);
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Grandpa1.SetActive(true);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Songe.SetActive(false);
            Grandpa.SetActive(true);
            Song5.SetActive(false);
            Grandpa4.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Grandpa1.activeSelf == true)
        {
            //송이 두번째 대화
            Debug.Log("c3");
            Opening.SetActive(false);
            Song1.SetActive(false);
            Song2.SetActive(true);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Songe.SetActive(true);
            Grandpa.SetActive(false);
            Song5.SetActive(false);
            Grandpa4.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Song2.activeSelf == true)
        {
            //할아버지 두번째 대화
            Debug.Log("c4");
            Opening.SetActive(false);
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(true);
            Grandpa3.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Songe.SetActive(false);
            Grandpa.SetActive(true);
            Song5.SetActive(false);
            Grandpa4.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Grandpa2.activeSelf == true)
        {
            //송이 세번째 대화
            Debug.Log("c5");
            Opening.SetActive(false);
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(true);
            Song4.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Songe.SetActive(true);
            Grandpa.SetActive(false);
            Song5.SetActive(false);
            Grandpa4.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Song3.activeSelf == true)
        {
            //할아버지 세번째 대화
            Debug.Log("c6");
            Opening.SetActive(false);
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(true);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Songe.SetActive(false);
            Grandpa.SetActive(true);
            Song5.SetActive(false);
            Grandpa4.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Grandpa3.activeSelf == true)
        {
            //송이 네번째 대화
            Debug.Log("c7");
            Opening.SetActive(false);
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(true);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Songe.SetActive(true);
            Grandpa.SetActive(false);
            Song5.SetActive(false);
            Grandpa4.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Song4.activeSelf == true)
        {
            //할아버지 네번째 대화
            Debug.Log("c8");
            Opening.SetActive(false);
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Songe.SetActive(false);
            Grandpa.SetActive(true);
            Song5.SetActive(false);
            Grandpa4.SetActive(true);
            Nextbutton.SetActive(false);
        }
        else if (Grandpa4.activeSelf == true)
        {
            //송이 다섯번째 대화
            Debug.Log("c9");
            Opening.SetActive(false);
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Songe.SetActive(true);
            Grandpa.SetActive(false);
            Song5.SetActive(true);
            Grandpa4.SetActive(false);
            Nextbutton.SetActive(true);
        }
        else if (Song5.activeSelf == true)
        {
            //다음씬으로
            Debug.Log("c10");
            //SceneManager.LoadScene("Scene3");
        }
    }
}
