using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class White_Blood_Cell_Manager : MonoBehaviour
{
    
    void OnBecameInvisible() {
        Destroy(gameObject);
    }

}
