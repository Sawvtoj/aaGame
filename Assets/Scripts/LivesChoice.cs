using UnityEngine;
using UnityEngine.UI;

public class LivesChoice : MonoBehaviour
{
    public Dropdown cDropdown;

    public static int playerLives = 3;
    public static bool lifeCheck = false;

    public void LifeChoice()
    {
        switch (cDropdown.value)
        {
            default:
                playerLives = 3;
                lifeCheck = true;
                break;

            case 1:
                playerLives = 1;
                lifeCheck = true;
                break;

            case 2:
                playerLives = 2;
                lifeCheck = true;
                break;

            case 3:
                playerLives = 3;
                lifeCheck = true;
                break;
        }
    }
}
