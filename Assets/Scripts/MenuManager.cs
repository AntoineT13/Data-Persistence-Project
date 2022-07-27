using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public InputField playerNameTextBox;

    public void StartButton()
    {
        SetPlayerName();
        SceneManager.LoadScene(1);
    }

    void SetPlayerName()
    {
        if (playerNameTextBox.text != null)
            PlayerSessionData.Instance.playerName = playerNameTextBox.text;
        else
            PlayerSessionData.Instance.playerName = "";
    }
}
