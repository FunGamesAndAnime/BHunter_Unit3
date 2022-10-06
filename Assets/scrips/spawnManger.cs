using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManger : MonoBehaviour
{
    public GameObject obsPrefab;
    private Vector3 spawnpos = new Vector3(15, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObs", 2, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnObs()
    {
        Instantiate(obsPrefab, spawnpos, obsPrefab.transform.rotation);
    }
    
}
