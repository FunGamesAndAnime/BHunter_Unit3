using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleft : MonoBehaviour
{
    public float speed;
    private playerContralor playerCtrl;
    private float LeftBound = -10;
    // Start is called before the first frame update
    void Start()
    {
       playerCtrl = GameObject.Find("player").GetComponent<playerContralor>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCtrl.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < LeftBound && gameObject.CompareTag("Obstacle"))
        {


            Destroy(gameObject);
        }
    }
}
