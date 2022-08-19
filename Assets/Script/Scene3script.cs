using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Scene3script : MonoBehaviour, IPointerDownHandler
{
    //public int count;
    public GameObject Song1;
    public GameObject Song2;
    public GameObject Song3;
    public GameObject Song4;
    public GameObject Song5;
    public GameObject Liar1;
    public GameObject Liar2;
    public GameObject Liar3;
    public GameObject Liar4;
    public GameObject Liar5;
    public GameObject Woongseong;
    public GameObject PinkFlower;
    public GameObject WhiteFlower;
    public GameObject Song;
    public GameObject FirstLiar;
    public GameObject SecondLiar;
    public GameObject ThirdLiar;
    public GameObject FourthLiar;

    void Start()
    {
        //송이 첫번째 대화
        Song1.SetActive(true);
        Song2.SetActive(false);
        Song3.SetActive(false);
        Song4.SetActive(false);
        Song5.SetActive(false);
        Liar1.SetActive(false);
        Liar2.SetActive(false);
        Liar3.SetActive(false);
        Liar4.SetActive(false);
        Liar5.SetActive(false);
        Woongseong.SetActive(false);
        PinkFlower.SetActive(true);
        WhiteFlower.SetActive(false);
        Song.SetActive(true);
        FirstLiar.SetActive(false);
        SecondLiar.SetActive(false);
        ThirdLiar.SetActive(false);
        FourthLiar.SetActive(false);
    }

    public void OnPointerDown(PointerEventData data)
    {

        if (Song1.activeSelf == true)
        {
            //수군수군
            Debug.Log("c1");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Liar1.SetActive(false);
            Liar2.SetActive(false);
            Liar3.SetActive(false);
            Liar4.SetActive(false);
            Liar5.SetActive(false);
            Woongseong.SetActive(true);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            FirstLiar.SetActive(false);
            SecondLiar.SetActive(false);
            ThirdLiar.SetActive(false);
            FourthLiar.SetActive(false);
        }
        else if (Woongseong.activeSelf == true)
        {
            //송이 두번째 대화
            Debug.Log("c2");
            Song1.SetActive(false);
            Song2.SetActive(true);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Liar1.SetActive(false);
            Liar2.SetActive(false);
            Liar3.SetActive(false);
            Liar4.SetActive(false);
            Liar5.SetActive(false);
            Woongseong.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            FirstLiar.SetActive(false);
            SecondLiar.SetActive(false);
            ThirdLiar.SetActive(false);
            FourthLiar.SetActive(false);
        }
        else if (Song2.activeSelf == true)
        {
            //거짓말쟁이 첫번째 대화
            Debug.Log("c3");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Liar1.SetActive(true);
            Liar2.SetActive(false);
            Liar3.SetActive(false);
            Liar4.SetActive(false);
            Liar5.SetActive(false);
            Woongseong.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            FirstLiar.SetActive(true);
            SecondLiar.SetActive(false);
            ThirdLiar.SetActive(false);
            FourthLiar.SetActive(false);
        }
        else if (Liar1.activeSelf == true)
        {
            //거짓말쟁이 두번째 대화
            Debug.Log("c4");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Liar1.SetActive(false);
            Liar2.SetActive(true);
            Liar3.SetActive(false);
            Liar4.SetActive(false);
            Liar5.SetActive(false);
            Woongseong.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            FirstLiar.SetActive(false);
            SecondLiar.SetActive(true);
            ThirdLiar.SetActive(false);
            FourthLiar.SetActive(false);
        }
        else if (Liar2.activeSelf == true)
        {
            //거짓말쟁이 세번째 대화
            Debug.Log("c5");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Liar1.SetActive(false);
            Liar2.SetActive(false);
            Liar3.SetActive(true);
            Liar4.SetActive(false);
            Liar5.SetActive(false);
            Woongseong.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            FirstLiar.SetActive(false);
            SecondLiar.SetActive(false);
            ThirdLiar.SetActive(true);
            FourthLiar.SetActive(false);
        }
        else if (Liar3.activeSelf == true)
        {
            //송이 세번째 대화
            Debug.Log("c6");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(true);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Liar1.SetActive(false);
            Liar2.SetActive(false);
            Liar3.SetActive(false);
            Liar4.SetActive(false);
            Liar5.SetActive(false);
            Woongseong.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            FirstLiar.SetActive(false);
            SecondLiar.SetActive(false);
            ThirdLiar.SetActive(false);
            FourthLiar.SetActive(false);
        }
        else if (Song3.activeSelf == true)
        {
            //거짓말쟁이 네번째 대화
            Debug.Log("c7");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Liar1.SetActive(false);
            Liar2.SetActive(false);
            Liar3.SetActive(false);
            Liar4.SetActive(true);
            Liar5.SetActive(false);
            Woongseong.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            FirstLiar.SetActive(false);
            SecondLiar.SetActive(false);
            ThirdLiar.SetActive(false);
            FourthLiar.SetActive(true);
        }
        else if (Liar4.activeSelf == true)
        {
            //송이 네번째 대화
            Debug.Log("c8");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(true);
            Song5.SetActive(false);
            Liar1.SetActive(false);
            Liar2.SetActive(false);
            Liar3.SetActive(false);
            Liar4.SetActive(false);
            Liar5.SetActive(false);
            Woongseong.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            FirstLiar.SetActive(false);
            SecondLiar.SetActive(false);
            ThirdLiar.SetActive(false);
            FourthLiar.SetActive(false);
        }
        else if (Song4.activeSelf == true)
        {
            //거짓말쟁이 다섯번째 대화
            Debug.Log("c9");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Liar1.SetActive(false);
            Liar2.SetActive(false);
            Liar3.SetActive(false);
            Liar4.SetActive(false);
            Liar5.SetActive(true);
            Woongseong.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            FirstLiar.SetActive(true);
            SecondLiar.SetActive(false);
            ThirdLiar.SetActive(false);
            FourthLiar.SetActive(false);
        }
        else if (Liar5.activeSelf == true)
        {
            //송이 다섯번째 대화
            Debug.Log("c10");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(true);
            Liar1.SetActive(false);
            Liar2.SetActive(false);
            Liar3.SetActive(false);
            Liar4.SetActive(false);
            Liar5.SetActive(false);
            Woongseong.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            FirstLiar.SetActive(false);
            SecondLiar.SetActive(false);
            ThirdLiar.SetActive(false);
            FourthLiar.SetActive(false);
        }
        else if (Song5.activeSelf == true)
        {
            //다음씬으로
            Debug.Log("c11");
            SceneManager.LoadScene("Home");
        }
    }
}