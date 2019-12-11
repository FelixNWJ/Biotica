using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameObject player;

    public int scoreMultiplier = 1;

    private Text whiteBloodCellScoreUI;
    private float whiteBloodCellScore = 0;

    private Text distanceUI;
    private float distance = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        whiteBloodCellScoreUI = GameObject.Find("White_Blood_Cell_Score").GetComponent<Text>();
        whiteBloodCellScoreUI.text = "WBC: " + whiteBloodCellScore.ToString();

        distanceUI = GameObject.Find("Distance").GetComponent<Text>(); 
        distanceUI.text = "Distance: 0";
    }

    // Update is called once per frame
    void Update()
    {
        whiteBloodCellScoreUI.text = "WBC: " + whiteBloodCellScore.ToString();

        distance += Time.deltaTime;
        distanceUI.text = "Distance: " + distance.ToString();
    }

    public void increaseWhiteBloodCellScore() {
        whiteBloodCellScore += 1 * scoreMultiplier;
    }
}
