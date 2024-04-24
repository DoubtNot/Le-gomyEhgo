using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Vector2 initialTouchPosition;
    private Vector2 finalTouchPosition;
    private bool isSwipe;

    public float swipeThreshold = 1f;
    public GroundMove groundMove;

    public void OnPointerDown(PointerEventData eventData)
    {
        initialTouchPosition = eventData.position;
        isSwipe = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        finalTouchPosition = eventData.position;
        DetectSwipe();
    }

    private void DetectSwipe()
    {
        float swipeDistance = Vector2.Distance(initialTouchPosition, finalTouchPosition);

        if (swipeDistance < swipeThreshold)
        {
            // If the swipe distance is less than the threshold, treat it as a tap and move forward
            groundMove.MoveForward();
            return;
        }

        float swipeAngle = Mathf.Atan2(finalTouchPosition.y - initialTouchPosition.y, finalTouchPosition.x - initialTouchPosition.x) * Mathf.Rad2Deg;

        // Horizontal swipe
        if (Mathf.Abs(swipeAngle) < 45 || Mathf.Abs(swipeAngle) > 135)
        {
            if (finalTouchPosition.x > initialTouchPosition.x)
            {
                // Right swipe
                groundMove.MoveRight();
            }
            else
            {
                // Left swipe
                groundMove.MoveLeft();
            }
        }
        // Vertical swipe
        else
        {
            if (swipeAngle < 0)
            {
                // Swipe from top to bottom
                groundMove.MoveBack();
            }
            else
            {
                // Swipe from bottom to top
                groundMove.MoveForward();
            }
        }
    }





}
