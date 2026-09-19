using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Reference to the target vehicle object that the camera will follow
    public GameObject vehicle;

    // Offset distance maintained between the camera and the vehicle
    private Vector3 offset = new Vector3(0, 5, -7);

    void Start()
    {
        // Initialization logic can go here if needed
    }

    void Update()
    {
        // Update the camera's position to match the vehicle's current position plus the predefined offset
        transform.position = vehicle.transform.position + offset;
    }
}