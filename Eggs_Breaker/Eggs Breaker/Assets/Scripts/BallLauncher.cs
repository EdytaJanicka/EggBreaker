using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class BallLauncher : MonoBehaviour
{
    
    private Rigidbody2D ball;
    public static bool isBallThrown;
    public PointsCounter points;
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        isBallThrown = false;
        
    }
    void FixedUpdate()
    {
        
        if (Input.GetMouseButtonUp(0))
        {       if(isBallThrown == false)
            {
                throwBall();
            }  
        }
    }
      
    private void throwBall()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var mouseDirection = mousePosition - gameObject.transform.position;
        mouseDirection.z = 0.0f;
        mouseDirection = mouseDirection.normalized;
        ball.AddForce(mouseDirection /50);
        isBallThrown = true;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        points.points++;
    }

}