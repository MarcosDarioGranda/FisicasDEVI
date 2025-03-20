using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionExplode : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
