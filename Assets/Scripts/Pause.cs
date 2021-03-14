using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Stop();
            }
        }
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Stop()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Debug.Log("Quitting Game");
        Time.timeScale = 1f;
        SceneManager.LoadScene("EndGame");
    }
}
