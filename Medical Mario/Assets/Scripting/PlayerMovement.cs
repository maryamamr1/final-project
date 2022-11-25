using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float Move;
    
    public float speed;

    public float jump;

    private bool isJumping;
    private bool facingRight;
    private Animator anim;

    private Rigidbody2D rb;

    [SerializeField] private AudioSource jumpSoundEffect;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        facingRight = true;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(Move * speed, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && isJumping == false)
        {
            jumpSoundEffect.Play();
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            Debug.Log("jump");
        }
        if(isJumping == true)
        {
            anim.SetBool("isJumping", true);
        }
        else
        {
            anim.SetBool("isJumping", false);
        }
        Flip (Move);

        if(Move == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }

    private void Flip(float Move)
    {
        if (Move > 0 && !facingRight || Move < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}

//Followed tutorial for this code using https://www.youtube.com/watch?v=nPigL-dIqgE&t=1949s&ab_channel=bblakeyyy