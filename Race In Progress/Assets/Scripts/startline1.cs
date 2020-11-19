using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startline1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { private int score = 0;
    public void Icreasescore( int increase)
    {
        score += increase;
        scoreText.text = "Счет игрока 1:" + score;

    }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
