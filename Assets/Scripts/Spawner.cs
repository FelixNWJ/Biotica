using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject backgroundToMoveNext;

    public GameObject backgroundToMoveSecond;

    public GameObject germToSpawn;

    public float timeBetweenSpawningGerms;
    private float timeLeftToSpawnGerms;

    public GameObject collectibleToSpawn;

    public float timeBetweenSpawningCollectibles;
    private float timeLeftToSpawnCollectibles;

    // Start is called before the first frame update
    void Start()
    {
        timeLeftToSpawnGerms = timeBetweenSpawningGerms;

        timeLeftToSpawnCollectibles = timeBetweenSpawningCollectibles;
    }

    // Update is called once per frame
    void Update()
    {

        if(timeLeftToSpawnGerms <= 0) {
            //Spawn Germ
            float yCoordinateOfGerm = Random.Range(-10, 11);
            Vector3 positionOfGermToSpawn = new Vector3(transform.position.x, yCoordinateOfGerm, 0);
            Instantiate(germToSpawn, positionOfGermToSpawn, transform.rotation);


            //Reset Timer
            timeLeftToSpawnGerms = timeBetweenSpawningGerms;

        } else {

            //Reduce Timer
            timeLeftToSpawnGerms -= Time.deltaTime;

        }

        if(timeLeftToSpawnCollectibles <= 0) {
            //Spawn Collectible
            float yCoordinateOfCollectible = Random.Range(-10, 11);
            Vector3 positionOfCollectibleToSpawn = new Vector3(transform.position.x, yCoordinateOfCollectible, 0);
            Instantiate(collectibleToSpawn, positionOfCollectibleToSpawn, transform.rotation);


            //Reset Timer
            timeLeftToSpawnCollectibles = timeBetweenSpawningCollectibles;

        } else {

            //Reduce Timer
            timeLeftToSpawnCollectibles -= Time.deltaTime;

        }

    }

    void FixedUpdate() {

        if(backgroundToMoveNext.transform.position.x <= -87) {

            backgroundToMoveNext.transform.position = new Vector3(143, backgroundToMoveNext.transform.position.y, 0);

            GameObject temp = backgroundToMoveNext;
            backgroundToMoveNext = backgroundToMoveSecond;
            backgroundToMoveSecond = temp;
        }

    }
}
