using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    private int Count = 0;

    public void SaveCount(int count)
    {
        Count = count;
        SaveGame();
    }
    public int LoadCount()
    {
        LoadGame();
        return Count;
    }
    private void SaveGame()
    {

        PlayerPrefs.SetInt("Count", Count);
        PlayerPrefs.Save();
    }
    private void LoadGame()
    {
        if (PlayerPrefs.HasKey("Count"))
        {
            Count = PlayerPrefs.GetInt("Count");
            Debug.Log("Game data loaded!");
            return;
        }

        Debug.LogError("There is no save data!");
        Count = 0;
    }
}
