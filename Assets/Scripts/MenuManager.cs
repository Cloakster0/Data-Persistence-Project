using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    public string playerName;
    public int currentScore;
    public int highScore;
    public string highscoreName;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    [System.Serializable]
    public class SaveData
    {
        public int highScore;
        public string highscoreName;
    }
    public void SaveHighScore(int currentScore, string playerName)
    {
        SaveData data = new SaveData();

        data.highScore = currentScore;
        data.highscoreName = playerName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }
    public void LoadHighScore ()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.highScore;
            highscoreName = data.highscoreName;
        }
    }
}
