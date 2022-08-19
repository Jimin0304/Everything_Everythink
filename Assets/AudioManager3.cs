using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AudioManager3 : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}