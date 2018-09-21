using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMvmt : MonoBehaviour {

    private Rigidbody rb;
    private Vector3 jump;
    private Vector3 moveForce;
    public float speed;

    bool bLeftReq, bRightReq;

    Vector3 vDirectModifier;
    private bool isGrounded;
    public float jumpForce = 2.0f;

    void Start () {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        moveForce = new Vector3(0.0f, 0.0f, 2.0f);
    }

    // Update is called once per frame
    void Update () {

        // WALK
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-speed * moveForce, ForceMode.Force);
            bLeftReq = true;
        }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(speed * moveForce, ForceMode.Force);
            bRightReq = true;
        }


        // JUMP
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

    }


    void FixedUpdate()
    {
        /*vDirectModifier.z = 0;

        // WALK
        if (bLeftReq)
        {
            bLeftReq = false;
            vDirectModifier.z -= speed;
        }
        if (bRightReq)
        {
            bRightReq = false;
            vDirectModifier.z += speed;
        }

        rb.velocity = vDirectModifier;*/
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }


}
