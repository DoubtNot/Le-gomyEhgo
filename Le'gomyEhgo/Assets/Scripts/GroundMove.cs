using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public float moveDistance = 20f; // Distance to move backward each time
    public float speed = 20f; // Speed at which the object moves backward

    public void MoveForward()
    {
        // Move the object backward by the specified distance and speed
        transform.Translate(Vector3.forward * moveDistance * speed * Time.fixedDeltaTime);
    }

    public void MoveLeft()
    {
        // Move the object left by half the specified distance and speed
        transform.Translate(Vector3.left * (moveDistance / 2f) * speed * Time.fixedDeltaTime);
    }

    public void MoveRight()
    {
        // Move the object right by half the specified distance and speed
        transform.Translate(Vector3.right * (moveDistance / 2f) * speed * Time.fixedDeltaTime);
    }

    public void MoveBack()
    {
        // Move the object forward by the specified distance and speed
        transform.Translate(Vector3.back * moveDistance * speed * Time.fixedDeltaTime);
    }
}
