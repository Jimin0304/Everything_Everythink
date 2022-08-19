using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndSt2 : MonoBehaviour
{
    public void ExitClickButton()
    {
        Debug.Log("눌림");
        SceneManager.LoadScene("Home");
    }
}

