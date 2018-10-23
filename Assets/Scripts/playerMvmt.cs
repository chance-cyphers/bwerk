using UnityEngine;

public class playerMvmt : MonoBehaviour
{
    CharacterController characterController;
    public float speed = 18.0f;
    public float jumpSpeed = 8.0f;
    Rigidbody rb;
    bool isGrounded = true;

    Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = -Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveVertical, 0.0f, moveHorizontal);
        rb.AddForce(movement * speed);

        if (isGrounded && Input.GetButton("Jump"))
        {
            rb.AddForce(new Vector3(0.0f, jumpSpeed, 0.0f), ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        isGrounded = other.gameObject.tag == "Ground";
    }

    void OnCollisionExit(Collision other)
    {
        isGrounded = other.gameObject.tag == "Ground";
    }

}
