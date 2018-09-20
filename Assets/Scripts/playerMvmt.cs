using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMvmt : MonoBehaviour {

    private Rigidbody rb;
    public float speed;

    bool bLeftReq, bRightReq;

    Vector3 vDirectModifier;
   

    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
            bLeftReq = true;
        }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            bRightReq = true;
        }
            
    }


    void FixedUpdate()
    {
        vDirectModifier.z = 0;

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

        rb.velocity = vDirectModifier;
    }
}
