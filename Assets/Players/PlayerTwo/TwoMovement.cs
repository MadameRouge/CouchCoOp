using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody2D))]

public class TwoMovement : MonoBehaviour
{
    private float MovementSpeed = 5;
    private float Jump = 7;
    private Rigidbody2D rb;

    public GameObject Player2;

    private Vector2 moveDirection = Vector2.zero;
    private Vector2 lookDirection = Vector2.zero;

    //private int LayerCheck;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        //Couldn't get jump to work correctly or some reason, seems like 2D doesn't like my attempt at a Raycast.
        //Player Movement
        if (Input.GetKey("[8]"))
        {
            //LayerCheck = 13;
            //RaycastHit hit;
            //Debug.Log("Raycast shot");
            //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector2.down), out hit, 10f, LayerCheck))
            //{
            Debug.Log("Player 2 Jumped");
            rb.velocity = new Vector2(0, Jump);
            //}
        }
        if (Input.GetKey("[4]"))
        {
            Debug.Log("Player 2 Left");
            rb.velocity = new Vector2(-MovementSpeed, 0);
        }
        if (Input.GetKey("[5]"))
        {
            Debug.Log("Player 2 Down");
            rb.velocity = new Vector2(0, -Jump);
        }
        if (Input.GetKey("[6]"))
        {
            Debug.Log("Player 2 Right");
            rb.velocity = new Vector2(MovementSpeed, 0);
        }
    }
}
