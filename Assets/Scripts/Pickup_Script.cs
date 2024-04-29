using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_Script : MonoBehaviour { 

    public float scoreValue;
    public GameManagerScript gameManager;

    // Start is called before the first frame update
    void Start()
    {
                gameManager = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<GameManagerScript>(); //finds the game manager object and gets the GameManagerScript component

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
