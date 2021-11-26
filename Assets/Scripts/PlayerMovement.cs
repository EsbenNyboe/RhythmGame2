using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float inputMultiplier;

    float moveHorizontal;
    float moveVertical;

    Rigidbody2D rb2D;

    public CharacterController controller;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        InputStore();
    }

    void FixedUpdate()
    {
        InputApply();
    }

    void InputStore()
    {
        moveHorizontal = InputConversion("Horizontal");
        moveVertical = InputConversion("Vertical");
    }

    float InputConversion(string axis)
    {
        return Input.GetAxis(axis) * inputMultiplier;
    }

    void InputApply()
    {
        //transform.position += new Vector3(inputHorizontal, inputVertical, 0);
        rb2D.velocity = new Vector2(moveHorizontal, moveVertical);
        //transform.Translate(new Vector2(moveHorizontal, moveVertical));
    }



}
