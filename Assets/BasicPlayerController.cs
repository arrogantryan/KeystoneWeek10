using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BasicPlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        Vector3 velocity = new Vector3(move.x * moveSpeed, rb.velocity.y, move.z * moveSpeed);
        rb.velocity = velocity;
    }

    bool IsGrounded()
    {
        // Simple raycast to check if touching the ground
        return Physics.Raycast(transform.position, Vector3.down, 1.1f, groundLayer);
    }
}