using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackScript : MonoBehaviour
{
    private LevelManager gameLevelManager;
    public int coinValue;

    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            gameLevelManager.AddCoins(coinValue);
            Destroy(gameObject);
        }
    }
}
