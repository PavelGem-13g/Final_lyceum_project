using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    public int jumpCounter = 2;
    public bool isBodyTolcheckRight = false;
    public bool isBodyTolcheckLeft = false;
    SpriteRenderer render;
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (transform.position.y < -15f)
        {
            transform.position = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.D) && !isBodyTolcheckRight)
        {
            rb.velocity = new Vector3(speed * Time.deltaTime, rb.velocity.y);
            render.flipX = false;
        }
        if (Input.GetKey(KeyCode.A) && !isBodyTolcheckLeft)
        {
            rb.velocity = new Vector3(-speed * Time.deltaTime, rb.velocity.y);
            render.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumpCounter > 0)
        {
            rb.AddForce(new Vector3(0, jumpForce * Time.deltaTime), ForceMode2D.Impulse);
            jumpCounter--;
        }
        if (rb.velocity.y>1f)
        {
            animator.Play("Jump");
        }
        else if (Mathf.Abs(rb.velocity.x) > 2f)
        {
            animator.Play("Moveing");
        }
        else
        {
            animator.Play("Staying");
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jumpCounter = 2;
        }
    }

}
