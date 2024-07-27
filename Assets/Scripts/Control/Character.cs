using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;


public class Character : MonoBehaviour
{
    public float MoveSpeed = 1.0f;
    public float JumpForce = 2.0f;
    public float LadderClimbSpeed = 8f;
    public LayerMask GroundLayer;
    public GameObject Key;
    public GameObject Lock;
    public GameObject Answer;
    public AudioSource JumpSound;
    public AudioSource KeyEquipped;
    public AudioSource OpenDoor;

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool isLadder;
    private bool isClimbing;
    private float vertical;
    private GameObject currentTeleporter;
    private bool HasKey = false;
    private bool hasJumped = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Answer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMovement();
        ClimbLadder();
        Jump();

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<Teleport>().GetDestination().position;
            }
        }

        if (HasKey && Input.GetKeyDown(KeyCode.E))
        {
            Unlock();
        }
        

    }

    private void CharacterMovement()
    {
        float MoveInput = Input.GetAxisRaw("Horizontal");
        Vector2 MoveVelocity = new Vector2(MoveInput * MoveSpeed, rb.velocity.y);
        rb.velocity = MoveVelocity;
        if (MoveInput > 0)
        {
            transform.localScale = new Vector3(1, 1,0 );
        }
        else if (MoveInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 0);
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            if (!hasJumped)
            {
                rb.velocity = new Vector2(rb.velocity.x, JumpForce);
                hasJumped = true;
                JumpSound.Play();
            }
        }
    }

    bool IsGrounded()
    {
        Vector2 Position = transform.position;
        Vector2 Direction = Vector2.down;
        float distance = 0.1f;

        RaycastHit2D hit = Physics2D.Raycast(Position, Direction, distance, GroundLayer);
        isGrounded = hit.collider != null;
        return isGrounded;
    }

    void ClimbLadder()
    {
        vertical = Input.GetAxisRaw("Vertical");

        if (isLadder && Mathf.Abs(vertical) > 0)
        {
            isClimbing = true;
        }

        if (isClimbing)
        {
            rb.gravityScale = 0;
            rb.velocity = new Vector2(rb.velocity.x, vertical * LadderClimbSpeed);
        }
        else
        {
            rb.gravityScale = 4f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = true;
            hasJumped = false;
        }
        if (collision.CompareTag("Ladder"))
        {
            isLadder = true;
        }
        if (collision.CompareTag("Door"))
        {
            currentTeleporter = collision.gameObject;
        }
        if (collision.CompareTag("Key"))
        {
            HasKey = true;
            Destroy(Key);
            KeyEquipped.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collsion)
    {
        if (collsion.CompareTag("Ladder"))
        {
            isLadder = false;
            isClimbing = false;
        }

        if (collsion.CompareTag("Door"))
        {
            if (collsion.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }

    private void Unlock()
    {
        Lock.SetActive(false);
        OpenDoor.Play();
        Answer.SetActive(true);
    }
}
