using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeadWall : MonoBehaviour
{
    private GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        gameManager.GetComponent<GameManager>().GameOver();
        Destroy(collision.gameObject);
    }
}
