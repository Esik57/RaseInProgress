using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public Text Playeronescore;
    public CheckpointSystem counter;


    
    void Update()
    {
        Playeronescore.text = $"Score: {counter} ";
    }
}
