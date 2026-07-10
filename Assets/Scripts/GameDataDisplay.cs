using UnityEngine;
using TMPro;

public class GameDataDisplay : MonoBehaviour
{
    public GameData gameData;
    public TMP_Text displayText;

    void Start()
    {
        displayText.text =
            "Name: " + gameData.playerName + "\n" +
            "Level: " + gameData.playerLevel + "\n" +
            "Health: " + gameData.playerHealth;
    }
}