using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public static bool IsBallThrown;
    public PointsCounter points;
    
    private Rigidbody2D _ball;

    private void Start()
    {
        _ball = GetComponent<Rigidbody2D>();
        IsBallThrown = false;
        
    }

    private void FixedUpdate()
    {
        
        if (Input.GetMouseButtonUp(0))
        {       if(IsBallThrown == false)
            {
                ThrowBall();
            }  
        }
    }
      
    private void ThrowBall()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var mouseDirection = mousePosition - gameObject.transform.position;
        mouseDirection.z = 0.0f;
        mouseDirection = mouseDirection.normalized;
        _ball.AddForce(mouseDirection /50);
        IsBallThrown = true;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        points.points++;
    }

}