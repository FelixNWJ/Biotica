using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class White_Blood_Cell_Score : MonoBehaviour
{

    private int whiteBloodCellScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "WBC: " + whiteBloodCellScore;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = "WBC: " + whiteBloodCellScore;
    }

    public void increaseWhiteBloodCellScore() {
        whiteBloodCellScore += 1 * GameObject.Find("GameManager").GetComponent<GameManager>().scoreMultiplier;
    }

    public int getWhiteBloodCellScore() {
        return whiteBloodCellScore;
    }

}
