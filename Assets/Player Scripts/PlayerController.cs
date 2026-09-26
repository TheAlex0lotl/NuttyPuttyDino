using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float rotationSpeed = 180f; // Degrees per second
    public float gravity = 9.81f;

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 1. Handle Rotation (A and D keys)
        float rotationInput = 0f;
        if (Input.GetKey(KeyCode.A)) rotationInput = -1f;
        if (Input.GetKey(KeyCode.D)) rotationInput = 1f;

        transform.Rotate(Vector3.up, rotationInput * rotationSpeed * Time.deltaTime);

        // 2. Handle Forward Movement (W key only)
        if (controller.isGrounded)
        {
            moveDirection = Vector3.zero;
            
            if (Input.GetKey(KeyCode.W))
            {
                moveDirection = transform.forward * moveSpeed;
            }
        }

        // 3. Apply Gravity and Move
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}