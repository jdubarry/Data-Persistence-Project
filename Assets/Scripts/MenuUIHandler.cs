using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.Events;

[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{
    private string playerName;
    public Text nameText;

    public void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            nameText.text = "Best Score: " + MainManager.highScoreName + " : " + MainManager.highScore;
        }
    }
    public void StartNew()
    {
        MainManager.playerName = playerName;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }

    public void UpdateName(string name)
    {
        playerName = name;
        Debug.Log(playerName);
    }
}
