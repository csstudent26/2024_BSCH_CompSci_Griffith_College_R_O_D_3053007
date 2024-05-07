using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bigScript_script : MonoBehaviour
{
    public TMP_Text playerScore;

    public TMP_Text enemyScore;
    public lastScript last;




    // Start is called before the first frame update
    void Start()
    {
        last = GameObject.FindGameObjectWithTag("Player2").GetComponent<lastScript>();
    }

    // Update is called once per frame
    void Update()
    {
        playerScore.text = "PlayerScore" + last.playerScore;
    }
}
