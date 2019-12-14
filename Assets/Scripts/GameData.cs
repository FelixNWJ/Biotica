using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{
    
    private int collectibleHighScore;

    private int distanceHighScore;

    public GameData(GameManager game) {
        this.collectibleHighScore = GameManager.getWhiteBloodCellHighScore();
        this.distanceHighScore = GameManager.getDistanceHighScore();
    }

    public int getCollectibleHighScore() {
        return collectibleHighScore;
    }

    public int getDistanceHighScore() {
        return distanceHighScore;
    }

}
