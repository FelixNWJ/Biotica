using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum GameStatus {

    Play,
    Pause

}

public class PauseMenu : MonoBehaviour
{

    static GameStatus currentGameStatus = GameStatus.Play;

    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (currentGameStatus == GameStatus.Play) {
                PauseGame();
            } else {
                ResumeGame();
            }
        }
    }

    public void PauseGame() {

        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        currentGameStatus = GameStatus.Pause;

    }

    public void ResumeGame() {

        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        currentGameStatus = GameStatus.Play;

    }

    public void ReturnToMainMenu() {

        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;

    }

    public void QuitGame() {

        Application.Quit();

    }

}
