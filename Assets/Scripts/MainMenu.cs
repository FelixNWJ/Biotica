using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    private GameManager gameManager;

    void Awake() {

        gameManager = GameObject.FindObjectOfType<GameManager>();

        GameObject.Find("PlayButton").GetComponent<Button>().onClick.AddListener( 
        () => gameManager.PlayGame());

        GameObject.Find("QuitButton").GetComponent<Button>().onClick.AddListener( 
        () => gameManager.QuitGame());

    }

}
