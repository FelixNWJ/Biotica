using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance_Score : MonoBehaviour
{

    private float distance = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "Distance: " + distance;
    }

    // Update is called once per frame
    void Update()
    {
        distance += Time.deltaTime;
        gameObject.GetComponent<Text>().text = "Distance :" + ((int)(distance));
    }

    public int getDistanceScore() {
        return ((int)distance);
    }

}
