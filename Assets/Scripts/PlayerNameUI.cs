using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerNameUI : MonoBehaviour
{
    private string input;
    
    public void StorePlayerName (string inputName)
    {
        MenuManager.instance.playerName = inputName;
    }
}
