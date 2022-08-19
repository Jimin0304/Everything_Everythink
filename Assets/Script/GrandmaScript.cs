using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GrandmaScript : MonoBehaviour, IPointerDownHandler
{
    //public int count;
    public GameObject Song1;
    public GameObject Song2;
    public GameObject Song3;
    public GameObject Song4;
    public GameObject Song5;
    public GameObject Song6;
    public GameObject Song7;
    public GameObject Grandma1;
    public GameObject Grandma2;
    public GameObject Grandma3;
    public GameObject Grandma4;
    public GameObject PinkFlower;
    public GameObject WhiteFlower;
    public GameObject Song;
    public GameObject Grandma;
    public GameObject Nextbutton;

    void Start()
    {
        //송이 첫번째 대화
        Song1.SetActive(true);
        Song2.SetActive(false);
        Song3.SetActive(false);
        Song4.SetActive(false);
        Song5.SetActive(false);
        Song6.SetActive(false);
        Song7.SetActive(false);
        Grandma1.SetActive(false);
        Grandma2.SetActive(false);
        Grandma3.SetActive(false);
        Grandma4.SetActive(false);
        PinkFlower.SetActive(true);
        WhiteFlower.SetActive(false);
        Song.SetActive(true);
        Grandma.SetActive(false);
        Nextbutton.SetActive(false);
    }

    public void OnPointerDown(PointerEventData data)
    {

        if (Song1.activeSelf == true)
        {
            //송이 두번째 대화
            Debug.Log("c1");
            Song1.SetActive(false);
            Song2.SetActive(true);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Song6.SetActive(false);
            Song7.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandma4.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            Grandma.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Song2.activeSelf == true)
        {
            //송이 세번째 대화
            Debug.Log("c2");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(true);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Song6.SetActive(false);
            Song7.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandma4.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            Grandma.SetActive(true);
            Nextbutton.SetActive(false);
        }
        else if (Song3.activeSelf == true)
        {
            //송이 네번째 대화
            Debug.Log("c3");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(true);
            Song5.SetActive(false);
            Song6.SetActive(false);
            Song7.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandma4.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            Grandma.SetActive(true);
            Nextbutton.SetActive(false);
        }
        else if (Song4.activeSelf == true)
        {
            //할머니 첫번째 대화
            Debug.Log("c4");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Song6.SetActive(false);
            Song7.SetActive(false);
            Grandma1.SetActive(true);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandma4.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Grandma.SetActive(true);
            Nextbutton.SetActive(false);
        }
        else if (Grandma1.activeSelf == true)
        {
            //송이 다섯번째 대화
            Debug.Log("c5");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(true);
            Song6.SetActive(false);
            Song7.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandma4.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            Grandma.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Song5.activeSelf == true)
        {
            //할머니 두번째 대화
            Debug.Log("c6");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Song6.SetActive(false);
            Song7.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(true);
            Grandma3.SetActive(false);
            Grandma4.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Grandma.SetActive(true);
            Nextbutton.SetActive(false);
        }
        else if (Grandma2.activeSelf == true)
        {
            //송이 여섯번째 대화
            Debug.Log("c7");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Song6.SetActive(true);
            Song7.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandma4.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            Grandma.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Song6.activeSelf == true)
        {
            //할머니 세번째 대화
            Debug.Log("c8");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Song6.SetActive(false);
            Song7.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(true);
            Grandma4.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Grandma.SetActive(true);
            Nextbutton.SetActive(false);
        }
        else if (Grandma3.activeSelf == true)
        {
            //송이 일곱번째 대화
            Debug.Log("c9");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Song6.SetActive(false);
            Song7.SetActive(true);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandma4.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            Grandma.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Song7.activeSelf == true)
        {
            //할머니 네번째 대화
            Debug.Log("c10");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(false);
            Song4.SetActive(false);
            Song5.SetActive(false);
            Song6.SetActive(false);
            Song7.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandma4.SetActive(true);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Grandma.SetActive(true);
            Nextbutton.SetActive(true);
        }
        else if (Grandma4.activeSelf == true)
        {
            //다음씬으로
            Debug.Log("c11");
            //SceneManager.LoadScene("Meet");
        }
    }
}