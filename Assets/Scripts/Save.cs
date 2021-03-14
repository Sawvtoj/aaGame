using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public void SavePref()
    {
        PlayerPrefs.SetString("Player Name", PlayerName.username);
        PlayerPrefs.SetFloat("Time Left", Timer.startTime);
        PlayerPrefs.SetInt("Lives Left", LiveCounter.lifeScore);
        PlayerPrefs.SetInt("Score", Score.PinCount);
    }

}
