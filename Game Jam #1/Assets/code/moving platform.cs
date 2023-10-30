using System.Collections;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Transform positionA; // The starting position
    public Transform positionB; // The ending position
    public float speed = 2.0f;  // The movement speed

    private Vector3 targetPosition;

    private void Start()
    {
        targetPosition = positionB.position;
    }

    private void Update()
    {
        // Move the platform towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Check if the platform has reached the target position
        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            // Ensure the platform stops exactly at the target position
            transform.position = targetPosition;

            // Swap the target position to create a continuous movement
            if (targetPosition == positionA.position)
            {
                targetPosition = positionB.position;
                Debug.Log("target position = pos_b");
            }
            else
            {
                targetPosition = positionA.position;
                Debug.Log("target position = pos_a");
            }
        }
    }
}
