using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUi : MonoBehaviour
{

    public void PlaySinglePlayer()
    {
        SceneManager.LoadScene("SelectSinglePlayerMapSceen");
    }

    public void PlayMultiplePlayer()
    {
        SceneManager.LoadScene("SelectMultiplePlayerMapScreen");
    }

    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
