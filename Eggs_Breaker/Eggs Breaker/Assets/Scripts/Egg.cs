using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private int HitsRemaing = 1;
    public bool InsideDontSpawn = false;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HitsRemaing--;
        if (HitsRemaing == 0) Destroy(gameObject);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        InsideDontSpawn = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        InsideDontSpawn = false;
    }
}
