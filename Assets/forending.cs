using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class forending : MonoBehaviour, IPointerDownHandler
{
    public GameObject EndingCreditImg;
    public GameObject EndingCreditText;
    public GameObject EndingText;

    void Start()
    {
        EndingCreditImg.SetActive(true);
        EndingCreditText.SetActive(true);
        EndingText.SetActive(false);
    }

    public void OnPointerDown(PointerEventData data)
    {

        if (EndingCreditImg.activeSelf == true && EndingCreditText.activeSelf == true)
        {
            EndingCreditImg.SetActive(false);
            EndingCreditText.SetActive(false);
            EndingText.SetActive(true);
        }
    }
}