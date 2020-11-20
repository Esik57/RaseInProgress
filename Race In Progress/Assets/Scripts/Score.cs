using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int counter = 0;
    public GameObject win;
    public Text score;

    private void OnTriggerEnter(Collider checkpoint)
    {
        if (checkpoint.CompareTag("4"))
        {
            counter++;
            score.text = counter.ToString();
            Debug.Log($"Rounds red = {counter}");
            if (counter > 1)
            {
                score.text = counter.ToString();
                win.SetActive(true);
            }
        }
    }
}
