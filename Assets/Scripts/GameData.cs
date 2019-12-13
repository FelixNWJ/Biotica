using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    
    float collectibleHighScore;

    int distanceHighScore;

    public GameData(GameManager game) {
        this.collectibleHighScore = game.getWhiteBloodCellScore();
        this.distanceHighScore = game.getDistance();
    }

}
