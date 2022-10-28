using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUI : MonoBehaviour
{
    public Text bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        MenuManager.instance.LoadHighScore();
        if (MenuManager.instance != null)
        {
            if (MenuManager.instance.highScore != 0)
            {
                DisplayHighScore();
            }
            else
            {
                DisplayName();
            }
        }
        else
        {
            bestScoreText.text = "Set a high score!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void DisplayHighScore()
    {
        bestScoreText.text = MenuManager.instance.playerName + ", beat the high score of " + MenuManager.instance.highScore + " by " + MenuManager.instance.highscoreName + "!";
    }
    private void DisplayName()
    {
        bestScoreText.text = MenuManager.instance.playerName + ", set the high score!";
    }
}
