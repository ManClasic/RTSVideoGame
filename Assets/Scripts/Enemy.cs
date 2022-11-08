using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sp;
    public float movHori = 1f;
    public float speed = 5f;
    public bool isGroundFloor = true;
    public bool isGroundFront = false;
    public LayerMask groundLayer;

    public int scoreGive = 50;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(movHori * speed, rb.velocity.y);

    }

    
}
