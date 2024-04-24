using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset;   // Offset from the player's position
    public float lerpSpeed = 5f; // Speed of camera movement

    void LateUpdate()
    {
        // Ensure that the player reference is not null
        if (player != null)
        {
            // Calculate the target position for the camera
            Vector3 targetPosition = player.position + offset;

            // Move the camera towards the target position using Lerp with the specified speed
            transform.position = Vector3.Lerp(transform.position, targetPosition, lerpSpeed * Time.deltaTime);
        }
    }
}
