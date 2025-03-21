using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDestroy : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
