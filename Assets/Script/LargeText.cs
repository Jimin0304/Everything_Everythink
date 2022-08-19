using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeText : MonoBehaviour
{
    public GameObject SUCCESS;
    float time;

    // Update is called once per frame
    void Update()
    {

        transform.localScale = Vector3.one * (1 + time);
        time += Time.deltaTime;
        if (time > 1f)
        {
            SUCCESS.SetActive(false);
            time = 0;
            SUCCESS.SetActive(true);
        }
    }

    public void resetAnim()
    {
        time = 0;
        transform.localScale = Vector3.one;
    }
}


