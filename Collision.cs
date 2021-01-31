using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("YOOOO");

        Destroy(col.gameObject);
        // Start is called before the first frame update
    }
}



