using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    public GameObject pauseUI;

    void Start()
    {
        pauseUI.SetActive(false);
    }

    public void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1;
    }

}
