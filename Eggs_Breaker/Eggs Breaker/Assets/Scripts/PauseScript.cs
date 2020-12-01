using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public void IsPaused()
    {



        if (GameIsPaused == true)
        {
            Resume();

        }
        else
        {
            Pause();
        }

    }
        public void Resume()
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1;
            GameIsPaused = false;
        }

        public void Pause()
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0;
            GameIsPaused = true;
        }
    
}