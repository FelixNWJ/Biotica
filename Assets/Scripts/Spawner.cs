using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject currentBackground;
    public GameObject backgroundToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(currentBackground.transform.position, new Vector3(0, 0, 0)) <= 0) {
            Instantiate(backgroundToSpawn, transform.position, transform.rotation);
        }
    }
}
