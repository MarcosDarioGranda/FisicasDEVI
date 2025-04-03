using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementForce : MonoBehaviour
{
    public float forceAmount = 10f;
    private Rigidbody rb;
    private bool randomize = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { 
            rb = GetComponent<Rigidbody>();

            if (randomize){


            }
            

        }

    }

}
