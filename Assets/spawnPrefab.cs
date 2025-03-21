using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnprefab()
    {
        Instantiate(prefab, new Vector3(i* 2.0f, 0, 0), Quaternion.identity);
    }

}
