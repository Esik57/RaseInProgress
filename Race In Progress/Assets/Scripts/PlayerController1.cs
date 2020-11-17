using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float angle = 2f;
    public Transform body;
    private float x;
    private float z;
    private float rotX = 0.0f;

    public bool isActive;
    public GameObject bomb;
    public float delay = 3f;
    public Transform dropSpot;
    private bool dropped = false;
    public float BombDelay = 5;

    public float gravity = -10f;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.3f;
    public LayerMask groundMask;
    private bool isGrounded;

    void Start()
    {
        isActive = true;
        Vector3 rotation = transform.localRotation.eulerAngles;
        rotX = rotation.x;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        if (isActive)
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            if (Input.GetKey(KeyCode.W))
            {
                controller.Move(body.forward * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rotX -= angle;
                body.rotation = Quaternion.Euler(0, rotX, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rotX += angle;
                body.rotation = Quaternion.Euler(0, rotX, 0);
            }

            if (Input.GetKey(KeyCode.S) && !dropped)
            {
                bomb.SetActive(true);
                bomb.transform.position = dropSpot.position;
                dropped = true;
                StartCoroutine("BombDropped");
            }

            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * 8f * Time.deltaTime);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Bomb"))
        {
            isActive = false;
            StartCoroutine("Waiting");
        }
    }

    IEnumerator BombDropped()
    {
        yield return new WaitForSeconds(BombDelay);
        dropped = false;
    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(delay);
        isActive = true;
    }
}
