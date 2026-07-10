using UnityEngine;

[CreateAssetMenu(fileName = "NewGameData", menuName = "Game Data/Game Data")]
public class GameData : ScriptableObject

{
    public int playerLevel;
    public float playerHealth;
    public string playerName;
}