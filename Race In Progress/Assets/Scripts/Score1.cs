using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    public int counter = 0;
    public GameObject win;
    public Text score;
    public GameObject Musicplayer;
    public GameObject pausepanel;    

    private void OnTriggerEnter(Collider checkpoint)
    {
        if (checkpoint.CompareTag("2"))
        {
            counter++;
            Debug.Log($"Rounds red = {counter}");
            if (counter == 10)
            {
                Musicplayer.SetActive(false);
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
        //Press F to win
        if (Input.GetKeyDown(KeyCode.F))
        {
            pausepanel.SetActive(false);
            counter = 10;
        }
        if (counter == 10)
        {
            Musicplayer.SetActive(false);
            win.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
        
    }
}
