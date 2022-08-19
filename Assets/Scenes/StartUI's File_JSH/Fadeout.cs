using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Fadeout : MonoBehaviour
{
    Text flashingText; // Use this for initialization 
    void Start()
    {
        flashingText = GetComponent<Text>(); StartCoroutine(BlinkText());
    }
    public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "touch to start";
            yield return new WaitForSeconds(.8f);
            flashingText.text = "        ";
            yield return new WaitForSeconds(.7f);
        }
    }
}