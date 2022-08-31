using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController instance;

    void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if (instance == null) instance = this;
    }

    [SerializeField]
    private GameObject pausePanel, gameOverPanel;
    public void PauseGameButton() {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeButton() {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OptionsButton() {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartButton() {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("GamePlay");
    }

    public void PlaneDiedShowPanel() {
        gameOverPanel.SetActive(true);

    }
}
