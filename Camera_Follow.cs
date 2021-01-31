using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform Nessie;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(Nessie.position.x, Nessie.position.y, Nessie.position.z - 2);
    }
}
