using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    public int counter = 0;
    public GameObject win;
    public Text score;

    private void OnTriggerEnter(Collider checkpoint)
    {
        if (checkpoint.CompareTag("4"))
        {
            counter++;
            Debug.Log($"Rounds red = {counter}");
            if (counter == 1)
            {
                win.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0;
            }
        }
    }
    public void Update()
    {
        score.text = $"{ counter}";
    }
}
