using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody2D rbd2d;
    private Vector2 inputs2d;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rbd2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputs2d.x = Input.GetAxisRaw("Horizontal");
        inputs2d.y = Input.GetAxisRaw("Vertical");

        inputs2d = inputs2d.normalized;

        animator.SetFloat("Horizontal", inputs2d.x);
        animator.SetFloat("Vertical", inputs2d.y);
        animator.SetFloat("Speed", inputs2d.magnitude);
    }

    private void FixedUpdate()
    {
        rbd2d.velocity = inputs2d * speed; // Corregido de linearVelocity a velocity
    }
}