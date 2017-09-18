using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Debug.Log("Hello. This code is inside of Start.");

        //This is code to teleport the player to a new position
        //transform.position = new Vector3(0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {


        float horizontalInput = Input.GetAxis("Horizontal");
        float speed = 0.2f;

        transform.Translate(speed * horizontalInput, 0, 0);
      

        if(Input.GetButtonDown("Jump"))
        {
            transform.Translate(0, 1, 0);
        }

	}
}
