using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    void Start()
    {
        Score.PinCount = 0;
    }

    public void Play()
    {
        if (LivesChoice.lifeCheck == false)
        {
            LiveCounter.lifeScore = 3;
        }

        else
        {
            LiveCounter.lifeScore = LivesChoice.playerLives;
        }

        if (TimeChoice.timeCheck == false)
        {
            Timer.startTime = 15f;
        }

        else
        {
            Timer.startTime = TimeChoice.gameTime;
        }

        SceneManager.LoadScene("MainLvl");
    }

    public void Exit()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    public void Setting()
    {
        SceneManager.LoadScene("Settings");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
