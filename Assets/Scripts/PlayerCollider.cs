using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{

    public PlayerMovement playerMovement;

    private GameManager gameManager;
    
    private AudioManager audioManager;
    
    void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        audioManager = gameManager.GetComponentInChildren<AudioManager>();
    }

    void OnTriggerEnter2D (Collider2D other) {

        if (other.gameObject.tag == "Enemy") {
            playerMovement.enabled = false;
        }

        if (other.gameObject.tag == "Background") {
            Debug.Log("Background hit");
        }

        if (other.gameObject.tag == "Collectible") {
            Destroy(other.gameObject);
            audioManager.Play("WhiteBloodCellCollected");
            Debug.Log("Collectible collided");
            gameManager.increaseWhiteBloodCellScore();
        }

        if (other.gameObject.tag == "PowerUp") {
            audioManager.Play("PowerUpCollected");
            StartCoroutine(other.GetComponent<PowerUp>().executePowerUp());
            Destroy(other.gameObject);
        }

    }

}
