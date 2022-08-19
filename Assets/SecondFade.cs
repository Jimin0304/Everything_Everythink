using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondFade : MonoBehaviour
{
    public Image nextSceneImage;
    public Image Panel;
    float time = 0f;
    float F_time = 1f;
    public void Fade()
    {
        StartCoroutine(FadeFlow());



    }
    IEnumerator FadeFlow()
    {
        Panel.gameObject.SetActive(true);
        time = 0f;
        Color alpha = Panel.color;
        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            Panel.color = alpha;
            yield return null;
        }
        time = 0f;

        yield return new WaitForSeconds(1f);
        nextSceneImage.gameObject.SetActive(true);
        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            Panel.color = alpha;
            yield return null;
        }

        ChangeScene();


        yield return null;


    }
    public void ChangeScene()
    {
        Debug.Log("씬변환");
        SceneManager.LoadScene("Meet");
    }
}

