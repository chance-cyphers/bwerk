using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMvmt : MonoBehaviour {

    private Rigidbody rb;
    public float speed;

    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(0.0f, 0.0f, moveHorizontal);

        rb.AddForce(movement * 50);
    }
}
