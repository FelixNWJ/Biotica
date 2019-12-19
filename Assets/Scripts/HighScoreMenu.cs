using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreMenu : MonoBehaviour
{
    
    void Awake() {

        GameObject.Find("ResetButton").GetComponent<Button>().onClick.AddListener(
            () => GameObject.FindObjectOfType<GameManager>().resetScore()
        );

    }

}
