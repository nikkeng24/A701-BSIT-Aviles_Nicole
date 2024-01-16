using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField] private float Speed;
    private Rigidbody2D body;
    public Animator animator;
    Vector2 movement;




    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void OnMovement()
    {

    }

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, body.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal") * Speed));

        movement.x = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, Speed);
        }

        if (movement.x != 0)
        {
            body.AddForce(new Vector2(movement.x * Speed, 0f));
        }

        if (movement.x > 0)
        {
            body.transform.localScale = new Vector3(2, 2, 2);
        }
        if (movement.x < 0)
        {
            body.transform.localScale = new Vector3(-2, 2, 2);
        }

    }



}
