using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpDoubleScore : PowerUp
{

    public override IEnumerator executePowerUp() {

        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.scoreMultiplier = 2;

        yield return new WaitForSeconds(10);

        reversePowerUp(gameManager);
    }

    public override void reversePowerUp(GameManager gameManager) {

        gameManager.scoreMultiplier = 1;

    }

}
