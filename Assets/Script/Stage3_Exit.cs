using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage3_Exit : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Home");
    }
}
