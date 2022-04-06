using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //State variables
    [SerializeField] float moveSpeed = 5f;//Allows to adjust player speed

    //Cached references
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;
    Vector2 movement;



    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");//Looks for player input, either arrow keys or WASD
        movement.y = Input.GetAxisRaw("Vertical");

        //Sets values for the animator
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
