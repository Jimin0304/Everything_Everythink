using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "maze")
        {
            Destroy(gameObject);
        }
    }
}
