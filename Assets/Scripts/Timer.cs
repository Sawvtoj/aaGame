using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float startTime;

    public Text timeText;

    void Start()
    {
        timeText.text = startTime.ToString();
    }

    void Update()
    {
        startTime -= Time.deltaTime;
        timeText.text = "Time: " + Mathf.Round(startTime).ToString();
    }
}
