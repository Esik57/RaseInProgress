using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");
        //Vector3 move = transform.forward;

        if (Input.GetKey(KeyCode.W))
        {
            controller.Move(body.forward * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            rotX -= angle;
            body.rotation = Quaternion.Euler(0, rotX, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rotX += angle;
            body.rotation = Quaternion.Euler(0,rotX,0);
        }
        

        //controller.Move(move*speed*Time.deltaTime);
        //body.Rotate(Vector3.up * 1);
    }
   
}
