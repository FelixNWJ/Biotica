using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{

    public PlayerMovement playerMovement;

    
    void OnTriggerEnter2D (Collider2D other) {

        if (other.gameObject.tag == "Obstacle") {
            playerMovement.enabled = false;
        }

    }

}
