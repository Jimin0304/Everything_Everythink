using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Scene5script : MonoBehaviour, IPointerDownHandler
{
    public GameObject Song1;
    public GameObject Song2;
    public GameObject Song3;
    public GameObject PinkFlower;
    public GameObject Song;

    void Start()
    {
        //송이 첫번째 대화
        Song1.SetActive(true);
        Song2.SetActive(false);
        Song3.SetActive(false);
        PinkFlower.SetActive(true);
        Song.SetActive(true);
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
            PinkFlower.SetActive(true);
            Song.SetActive(true);
        }
        else if (Song2.activeSelf == true)
        {
            //송이 세번째 대화
            Debug.Log("c1");
            Song1.SetActive(false);
            Song2.SetActive(false);
            Song3.SetActive(true);
            PinkFlower.SetActive(true);
            Song.SetActive(true);
        }
        else if (Song3.activeSelf == true)
        {
            //다음씬으로
            Debug.Log("c2");
            SceneManager.LoadScene("Stage3");
        }
    }
}
