using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public GameObject playerRotationObject; // Reference to the GameObject to rotate
    public float moveDistance = 20f; // Distance to move backward each time
    public float speed = 20f; // Speed at which the object moves backward

    public void MoveForward()
    {
        // Set the rotation of the player rotation object to face forward
        playerRotationObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

        // Move the object forward by the specified distance and speed
        transform.Translate(Vector3.forward * moveDistance * speed * Time.fixedDeltaTime);
    }

    public void MoveLeft()
    {
        // Set the rotation of the player rotation object to face left
        playerRotationObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);

        // Move the object left by half the specified distance and speed
        transform.Translate(Vector3.left * (moveDistance / 2f) * speed * Time.fixedDeltaTime);
    }

    public void MoveRight()
    {
        // Set the rotation of the player rotation object to face right
        playerRotationObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);

        // Move the object right by half the specified distance and speed
        transform.Translate(Vector3.right * (moveDistance / 2f) * speed * Time.fixedDeltaTime);
    }

    public void MoveBack()
    {
        // Set the rotation of the player rotation object to face backward
        playerRotationObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

        // Move the object forward by the specified distance and speed
        transform.Translate(Vector3.back * moveDistance * speed * Time.fixedDeltaTime);
    }
}
