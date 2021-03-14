using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    public void loadPref()
    {
        Debug.Log("PLayer Name: " + PlayerPrefs.GetString("Player Name", PlayerName.username) + "\n");
        PlayerName.username = PlayerPrefs.GetString("Player Name", PlayerName.username);
        
        Debug.Log("Time Left " + PlayerPrefs.GetFloat("Time Left", Timer.startTime) + "\n");
        Timer.startTime = PlayerPrefs.GetFloat("Time Left", Timer.startTime);

        Debug.Log("Lives Left: " + PlayerPrefs.GetInt("Lives Left", LiveCounter.lifeScore) + "\n");
        LiveCounter.lifeScore = PlayerPrefs.GetInt("Lives Left", LiveCounter.lifeScore);
        
        Debug.Log("Score: " + PlayerPrefs.GetInt("Score", Score.PinCount));
        Score.PinCount = PlayerPrefs.GetInt("Score", Score.PinCount);
    }
}
