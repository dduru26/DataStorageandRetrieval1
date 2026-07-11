using UnityEngine;
using TMPro;

public class PlayerPrefsManager : MonoBehaviour
{ 
    public TMP_Text displayText;
    private int score = 0; 

    void Start()
    {
        int savedScore = PlayerPrefs.GetInt("Score", 0);
        float savedVolume = PlayerPrefs.GetFloat("Volume", 1.0f);
        string savedName = PlayerPrefs.GetString("PlayerName", "Guest");

        score = savedScore; // continue from wherever we left off
        UpdateDisplay(savedScore, savedVolume, savedName);
    }

    public void SaveData()
    {
        score += 10;

        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetFloat("Volume", 0.75f);
        PlayerPrefs.SetString("PlayerName", "Donald");

        PlayerPrefs.Save();

        UpdateDisplay(score, 0.75f, "Donald");
    }

     void UpdateDisplay(int s, float v, string n)
    {
        displayText.text =
            "Score: " + s + "\n" +
            "Volume: " + v + "\n" +
            "Name: " + n;
    }
}