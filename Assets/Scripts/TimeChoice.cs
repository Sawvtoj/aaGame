using UnityEngine;
using UnityEngine.UI;

public class TimeChoice : MonoBehaviour
{
    public Dropdown timeDropdown;

    public static float gameTime;
    public static bool timeCheck = false;

    public Text timeText;

    public void gameTimeChoice()
    {
        switch (timeDropdown.value)
        {
            default:
                gameTime = 30f;
                timeCheck = true;
                break;

            case 1:
                gameTime = 15f;
                timeCheck = true;
                break;

            case 2:
                gameTime = 30f;
                timeCheck = true;
                break;

            case 3:
                gameTime = 60f;
                timeCheck = true;
                break;
        }
    }
}
