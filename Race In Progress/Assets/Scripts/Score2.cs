using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public int counter = 0;
    public GameObject win;
    public Text score;

    private void OnTriggerEnter(Collider checkpoint)
    {
        if (checkpoint.CompareTag("8"))
        {
            counter++;
            Debug.Log($"Rounds blue = {counter}");
            if (counter > 1)
            {
                win.SetActive(true);
            }
        }
    }
    public void Update()
    {
        score.text = $"SCORE:{ counter}";
    }
}
