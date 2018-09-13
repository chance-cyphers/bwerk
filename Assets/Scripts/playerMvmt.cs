using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMvmt : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var z = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;

        transform.Translate(0, 0, z);
    }
}
