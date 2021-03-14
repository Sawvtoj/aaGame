using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public InputField playerNameInput;
    public Text nameText;
    public static string username = "Player 1";

    public void FindName()
    {
        username = playerNameInput.text;
    }

    void Start()
    {
        nameText.text = username;
    }
}
