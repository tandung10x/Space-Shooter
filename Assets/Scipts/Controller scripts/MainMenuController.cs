using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGameButton() {
        SceneManager.LoadScene("GamePlay");
        //Application.LoadLevel("GamePlay");
    }

    // public void QuitGameButton() {
    //     Application.Quit()
    // }
}
