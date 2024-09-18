using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float jumpForce = 5f;
    private bool canJump = false;
    private IJumpBehavior jumpBehavior; // Strategy pattern

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        jumpBehavior = new StandardJump(rb, jumpForce); // Strategy pattern implementation
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && canJump)
        {
            jumpBehavior.Jump();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("Game");
        }
    }
}

public interface IJumpBehavior
{
    void Jump();
}

public class StandardJump : IJumpBehavior
{
    private Rigidbody rb;
    private float jumpForce;

    public StandardJump(Rigidbody rb, float jumpForce)
    {
        this.rb = rb;
        this.jumpForce = jumpForce;
    }

    public void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }
}
