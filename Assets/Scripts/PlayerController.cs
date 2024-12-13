using UnityEngine;

public class SimpleJumpController : MonoBehaviour
{
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    private Animator animator;
    private bool canJump = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canJump) // Salto al hacer clic y si puede saltar
        {
            Jump();
        }
        animator.SetBool("isGrounded", canJump);

    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        canJump = false; // Desactivar la opción de salto después de saltar
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        
            canJump = true; // Recargar la opción de salto al tocar el suelo
        
    }
}
