using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{

    public float moveSpeed;

    void FixedUpdate() {
        transform.position += new Vector3(-1, 0, 0) * Time.fixedDeltaTime * moveSpeed;
    }
    public abstract IEnumerator executePowerUp();

    public abstract void reversePowerUp(GameManager gameManager);

    void onBecameInvisible() {
        Destroy(gameObject);
    }

}
