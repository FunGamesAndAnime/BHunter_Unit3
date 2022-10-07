using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManger : MonoBehaviour
{
    public GameObject obsPrefab;
    private playerContralor playerCtrl;
    private Vector3 spawnpos = new Vector3(15, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObs", 2, 2);
        playerCtrl = GameObject.Find("player").GetComponent<playerContralor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnObs()
    {
        if (playerCtrl.gameOver == false)
        {
            Instantiate(obsPrefab, spawnpos, obsPrefab.transform.rotation);
        }
    }
    
}
