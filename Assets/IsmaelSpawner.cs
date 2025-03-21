using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsmaelSpawner : MonoBehaviour
{
    public GameObject Isma;
    void Start()
    {
        for (var i = 0; i < 10; i++)
        {
            Instantiate(Isma, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
}
