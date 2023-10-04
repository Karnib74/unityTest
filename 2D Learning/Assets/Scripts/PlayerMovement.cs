using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PlayerMovement : MonoBehaviour
{
    private NewControls input = null;
    private Vector2 moveVector = Vector2.zero;
    private Rigidbody2D rb = null;
    private float moveSpeed = 10f;

    private void Awake()
    {
        input = new NewControls();
        rb = GetComponent<Rigidbody2D>();

    }

    private void OnEnable()
    {
        input.Enable();
        input.player.movement.performed += OnMovementPerformed;
        input.player.movement.canceled += OnMovementPerformed;

    }

    private void OnDisable()
    {
        input.Disable();
        input.player.movement.performed -= OnMovementPerformed;
        input.player.movement.canceled -= OnMovementPerformed;
    }

    private void FixedUpdate()
    {
        rb.velocity = moveVector * moveSpeed;
        Debug.Log(moveVector);
    }

    private void OnMovementPerformed(InputAction.CallbackContext value)
    {
        moveVector = value.ReadValue<Vector2>();
    }

    private void OnMovementCanceled(InputAction.CallbackContext value)
    {
        moveVector = Vector2.zero;
    }

}