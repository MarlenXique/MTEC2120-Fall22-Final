using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();

    }

    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }
    void Start()
    {

    }
    private void Update()
    {
        playerControls.Land.Move.ReadValue<Vector2>();
        Debug.Log("move");
        //playerControls.Land.Jump.ReadValue<float>();
        //if (playerControls.Land.Jump.ReadValue<float>() == 1)
            if (playerControls.Land.Jump.triggered)
                Debug.Log("Jump");

    }
}
