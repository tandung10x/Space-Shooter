using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
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
        Application.LoadLevel("MainMenu");
    }

    public void RestartButton() {
        gameOverPanel.SetActive(false);
        Application.LoadLevel("GamePlay");
    }

    public void PlaneDiedShowPanel() {
        gameOverPanel.SetActive(true);

    }
}
