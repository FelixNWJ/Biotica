using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class White_Blood_Cell_High_Score : MonoBehaviour
{
    
    private int whiteBloodCellHighScore;
    void OnEnable()
    {
        whiteBloodCellHighScore = GameManager.getWhiteBloodCellHighScore();
        gameObject.GetComponent<TextMeshProUGUI>().text = "WBC: " + whiteBloodCellHighScore;
    }

    // Update is called once per frame
    void updateHighScore()
    {
        whiteBloodCellHighScore = GameManager.getWhiteBloodCellHighScore();
    }

}    
    