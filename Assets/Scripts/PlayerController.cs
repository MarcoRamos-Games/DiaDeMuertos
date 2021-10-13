using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private SpriteRenderer mySpriteRenderer;
    [SerializeField] private float moveSpeed, jumpForce;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private Transform groundPoint;
    [SerializeField] float jumpRemberedTime;
    [SerializeField] float groundRemeberdTime;

    private float jumpRembered;
    private float groundRembered;
    private bool isGrounded;
    private bool movingBackwards;
    private Vector2 moveInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        moveInput.Normalize();

        myRigidBody.velocity = new Vector3(moveInput.x * moveSpeed, myRigidBody.velocity.y, moveInput.y * moveSpeed);

        RaycastHit hit;
        if(Physics.Raycast(groundPoint.position, Vector3.down, out hit, .4f, whatIsGround))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        groundRembered -= Time.deltaTime;
        if (isGrounded)
        {

            groundRembered = groundRemeberdTime;
        }
        jumpRembered -= Time.deltaTime;
        if (Input.GetButtonDown("Jump"))
        {
            jumpRembered = jumpRemberedTime;

        }
        if ((jumpRembered > 0) && (groundRembered > 0))
        {
            jumpRembered = 0;
            groundRembered = 0;
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);

        }

        if(mySpriteRenderer.flipX && moveInput.x < 0)
        {
            mySpriteRenderer.flipX = false;
        }
        else if(!mySpriteRenderer.flipX && moveInput.x > 0)
        {
            mySpriteRenderer.flipX = true;
        }

        if(!movingBackwards && moveInput.y > 0)
        {
            movingBackwards = true;
        }
        else if (movingBackwards && moveInput.y < 0)
        {
            movingBackwards = false;
        }
    }
}
