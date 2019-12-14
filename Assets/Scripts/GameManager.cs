using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private static GameManager singletonGameManager;

    private GameObject player;

    public int scoreMultiplier = 1;

    private static int whiteBloodCellHighScore = 0;

    private static float distanceHighScore = 0;

    void Awake() {
        
        GameData dataLoaded = SaveSystem.loadScore();
        
        if (dataLoaded != null) {
            whiteBloodCellHighScore = dataLoaded.getCollectibleHighScore();
            distanceHighScore = dataLoaded.getDistanceHighScore();
        }
        
        if (singletonGameManager == null) {
            singletonGameManager = this;
        } else {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static int getWhiteBloodCellHighScore() {
        return whiteBloodCellHighScore;
    }

    public static int getDistanceHighScore() {
        return ((int)distanceHighScore);
    }

    public void PlayGame() {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void updateScore(int whiteBloodCellScore, int distanceScore) {

        if (whiteBloodCellScore > whiteBloodCellHighScore) {
            whiteBloodCellHighScore = whiteBloodCellScore;
        }

        if (distanceScore > distanceHighScore) {
            distanceHighScore = distanceScore;
        }

    }

}
