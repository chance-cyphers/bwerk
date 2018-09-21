using UnityEngine;

public class playerMvmt : MonoBehaviour {

    CharacterController characterController;
    public float speed = 18.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    Vector3 moveDirection = Vector3.zero;

    void Start () {
        characterController = GetComponent<CharacterController>();
    }

    void Update () {
        moveDirection = new Vector3(Input.GetAxis("Vertical"), 0.0f, Input.GetAxis("Horizontal"));
        moveDirection *= speed;

        if (Input.GetButton("Jump"))
        {
            moveDirection.y = jumpSpeed;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }

}
