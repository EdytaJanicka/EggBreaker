using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        Destroy(gameObject);
    }


    public GameObject egg;
    public float x = -1.5f;
    
    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(egg);
            transform.Translate(x, 3.5f, 0f);
            x = x + 0.75f;
        }
    }
}
