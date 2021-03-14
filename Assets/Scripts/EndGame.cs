using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    int endTime;
    
    string endName = PlayerName.username;
    int endScore = Score.PinCount;
    int endLives = LiveCounter.lifeScore;
    
    public Text ScoreText;
    public Text PlayerNameText;
    public Text LivesText;

    void Awake()
    {
        endTime = 20000;
    }

    void Start()
    {
        PlayerNameText.text = "Name: " + endName + "\n";
        ScoreText.text = "Score: " + endScore.ToString() + "\n";
        LivesText.text = "Lives: " + endLives.ToString();
    }
    
    void Update()
    {
        if (endTime <= 0)
        {
            SceneManager.LoadScene("Credits");
        }
        else
        {
            endTime -= (int)Time.time;
            Debug.Log(endTime);
        }
    }
}
