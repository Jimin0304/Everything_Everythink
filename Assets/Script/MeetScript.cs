using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MeetScript : MonoBehaviour, IPointerDownHandler
{
    //public int count;
    public GameObject Song1;
    public GameObject Song2;
    public GameObject Grandma1;
    public GameObject Grandma2;
    public GameObject Grandma3;
    public GameObject Grandpa1;
    public GameObject Grandpa2;
    public GameObject Grandpa3;
    public GameObject Grandpama;
    public GameObject PinkFlower;
    public GameObject WhiteFlower;
    public GameObject Song;
    public GameObject Grandma;
    public GameObject Grandpa;
    public GameObject Grandmama;
    public GameObject Grandpapa;
    public GameObject Nextbutton;

    void Start()
    {
        //할머니 첫번째 대화
        Song1.SetActive(false);
        Song2.SetActive(false);
        Grandma1.SetActive(true);
        Grandma2.SetActive(false);
        Grandma3.SetActive(false);
        Grandpa1.SetActive(false);
        Grandpa2.SetActive(false);
        Grandpa3.SetActive(false);
        Grandpama.SetActive(false);
        PinkFlower.SetActive(false);
        WhiteFlower.SetActive(true);
        Song.SetActive(false);
        Grandma.SetActive(true);
        Grandmama.SetActive(false);
        Grandpa.SetActive(false);
        Grandpapa.SetActive(false);
        Nextbutton.SetActive(false);
    }

    public void OnPointerDown(PointerEventData data)
    {

        if (Grandma1.activeSelf == true)
        {
            //할아버지 첫번째 대화
            Debug.Log("c1");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandpa1.SetActive(true);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            Grandpama.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Grandma.SetActive(false);
            Grandpa.SetActive(true);
            Grandpapa.SetActive(false);
            Grandmama.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Grandpa1.activeSelf == true)
        {
            //할머니 두번째 대화
            Debug.Log("c2");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(true);
            Grandma3.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            Grandpama.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Grandma.SetActive(true);
            Grandpa.SetActive(false);
            Grandpapa.SetActive(false);
            Grandmama.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Grandma2.activeSelf == true)
        {
            //할아버지 두번째 대화
            Debug.Log("c3");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(true);
            Grandpa3.SetActive(false);
            Grandpama.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Grandma.SetActive(false);
            Grandpa.SetActive(true);
            Grandpapa.SetActive(false);
            Grandmama.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Grandpa2.activeSelf == true)
        {
            //할머니 세번째 대화
            Debug.Log("c4");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(true);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            Grandpama.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Grandma.SetActive(true);
            Grandpa.SetActive(false);
            Grandpapa.SetActive(false);
            Grandmama.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Grandma3.activeSelf == true)
        {
            //할아버지 세번째 대화
            Debug.Log("c5");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(true);
            Grandpama.SetActive(false);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Grandma.SetActive(false);
            Grandpa.SetActive(true);
            Grandpapa.SetActive(false);
            Grandmama.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Grandpa3.activeSelf == true)
        {
            //할아버지할머니 세번째 대화
            Debug.Log("c6");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            Grandpama.SetActive(true);
            PinkFlower.SetActive(false);
            WhiteFlower.SetActive(true);
            Song.SetActive(false);
            Grandma.SetActive(true);
            Grandpa.SetActive(false);
            Grandpapa.SetActive(true);
            Grandmama.SetActive(true);
            Nextbutton.SetActive(false);
        }
        else if (Grandpama.activeSelf == true)
        {
            //송이 대화1
            Debug.Log("c7");
            Song1.SetActive(true);
            Song2.SetActive(false);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            Grandpama.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            Grandma.SetActive(false);
            Grandpa.SetActive(false);
            Grandpapa.SetActive(false);
            Grandmama.SetActive(false);
            Nextbutton.SetActive(false);
        }
        else if (Song1.activeSelf == true)
        {
            //송이 대화2
            Debug.Log("c8");
            Song1.SetActive(false);
            Song2.SetActive(true);
            Grandma1.SetActive(false);
            Grandma2.SetActive(false);
            Grandma3.SetActive(false);
            Grandpa1.SetActive(false);
            Grandpa2.SetActive(false);
            Grandpa3.SetActive(false);
            Grandpama.SetActive(false);
            PinkFlower.SetActive(true);
            WhiteFlower.SetActive(false);
            Song.SetActive(true);
            Grandma.SetActive(false);
            Grandpa.SetActive(false);
            Grandpapa.SetActive(false);
            Grandmama.SetActive(false);
            Nextbutton.SetActive(true);
        }
        else if (Song2.activeSelf == true)
        {
            //다음씬으로
            Debug.Log("c9");
            //SceneManager.LoadScene("EndingCredit");
        }
    }
}