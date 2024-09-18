using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float jumpForce = 5f;
    private bool canJump = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        

        // Fare sol tuşuna basılırsa ve yerdeysek zıpla
        if (Input.GetMouseButton(0) && canJump)
        {
            Jump();
        }
    }

    // Zıplama işlemi
    private void Jump()
    {
        // Zıplama kuvveti yerine doğrudan velocity ayarlıyoruz, bu sabit yükseklik sağlar
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }

    // Yerde olup olmadığını kontrol eden fonksiyon
    

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = false;
        }
    }
}
