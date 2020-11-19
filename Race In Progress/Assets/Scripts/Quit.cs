using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public GameObject Exit;
    //public GameObject PlayerOne;
    //public GameObject Playertwo;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Включение нормального хода времени
        Time.timeScale = 1;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit.SetActive(true);
            //PlayerOne.SetActive(false);
            //Playertwo.SetActive(false);

            // Вызов метода остановки времени
            StartCoroutine("pause");

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    // Остановка времени
    IEnumerator pause()
    {
        Time.timeScale = 0;
        gameObject.SetActive(false);
        yield return 0;
    }
}
