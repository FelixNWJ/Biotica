using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Distance_High_Score : MonoBehaviour
{
    private int distanceHighScore;
    void OnEnable()
    {
        distanceHighScore = GameManager.getDistanceHighScore();
        gameObject.GetComponent<TextMeshProUGUI>().text = "Distance: " + distanceHighScore;
    }

    // Update is called once per frame
    void updateHighScore()
    {
        distanceHighScore = GameManager.getDistanceHighScore();
    }

    public void updateHighScoreText() {
        updateHighScore();
        gameObject.GetComponent<TextMeshProUGUI>().text = "Distance: " + distanceHighScore;
    }
}
