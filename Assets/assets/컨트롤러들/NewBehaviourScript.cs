using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public GameObject btn;
    public GameObject circle;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            btn.SetActive(true);
            circle.SetActive(true);
        }
    }
}
