using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float angle = 2;
    public Transform body;
    private float x;
    private float z;
    private float rotX = 0.0f;
    void Start()
    {
        Vector3 rotation = transform.localRotation.eulerAngles;
        rotX = rotation.x;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            controller.Move(body.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotX -= angle;
            body.rotation = Quaternion.Euler(0, rotX, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotX += angle;
            body.rotation = Quaternion.Euler(0, rotX, 0);
        }

    }
}
