using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D myRigidBody;
    private Vector2 change;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if (movement != 0)
        {
            animator.SetFloat("moveX", movement);
            animator.SetBool("moving", true);
        } else
        {
            animator.SetBool("moving", false);
        }
        if(Input.GetButtonDown("Jump") && Mathf.Abs(myRigidBody.velocity.y) < 0.001f)
        {
            myRigidBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

}
