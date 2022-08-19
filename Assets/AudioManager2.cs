using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AudioManager2 : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Meet")
        {
            Destroy(gameObject);
        }
    }
}