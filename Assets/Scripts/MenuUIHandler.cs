using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI BestScoreText;

    private void Start()
    {
        BestScoreText.text = $"Best Score : {HighScoreHandler.Instance.PlayerName} - {HighScoreHandler.Instance.HighScore}";
    }

    public void StartMain()
    {
        SceneManager.LoadScene("main");
    }

    public void ReadStringInput(string playerName)
    {
        HighScoreHandler.Instance.newPlayerName = playerName;
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
