using UnityEngine;
using UnityEngine.InputSystem;

public class VehicleMovement : MonoBehaviour
{
    public float speed;

    public float turnSpeed;

    public InputAction moveAction;

    public Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        transform.Translate(Vector3.forward * speed * Time.deltaTime * moveInput.y);

        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * moveInput.x);
    }
}

