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

    public GameObject powerUpToSpawn;

    public float timeBetweenSpawningPowerUps;
    private float timeLeftToSpawnPowerUps;

    // Start is called before the first frame update
    void Start()
    {
        timeLeftToSpawnGerms = timeBetweenSpawningGerms;

        timeLeftToSpawnCollectibles = timeBetweenSpawningCollectibles;

        timeLeftToSpawnPowerUps = timeBetweenSpawningPowerUps;
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

        if(timeLeftToSpawnPowerUps <= 0) {
            //Spawn Collectible
            float yCoordinateOfPowerUp = Random.Range(-10, 11);
            Vector3 positionOfPowerUpToSpawn = new Vector3(transform.position.x, yCoordinateOfPowerUp, 0);
            Instantiate(powerUpToSpawn, positionOfPowerUpToSpawn, transform.rotation);


            //Reset Timer
            timeLeftToSpawnPowerUps = timeBetweenSpawningPowerUps;

        } else {

            //Reduce Timer
            timeLeftToSpawnPowerUps -= Time.deltaTime;

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
