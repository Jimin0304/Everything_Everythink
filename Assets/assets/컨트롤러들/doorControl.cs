using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorControl : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject door;
    public GameObject potal;
    
    // Update is called once per frame
    void Update()
    {
        if (one.activeSelf == true && two.activeSelf == true && three.activeSelf == true && four.activeSelf == true)
        {
            door.SetActive(false);
            potal.SetActive(true);
        }
    }
}
