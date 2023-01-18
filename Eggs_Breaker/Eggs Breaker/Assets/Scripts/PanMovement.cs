using UnityEngine;

public class PanMovement : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float moveSpeed = 30f;
    private static bool CanMove;
    
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }


    private void Update()
    {
        if (Input.GetMouseButton(0) && CanMove)
        {
            var mousePos = Input.mousePosition;
            touchPosition = Camera.main.ScreenToWorldPoint(mousePos);
            touchPosition.z = 0;
            touchPosition.y = -4;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
