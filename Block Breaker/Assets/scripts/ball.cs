using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    private paddle myPaddle;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;

    // Use this for initialization
    void Start () {

        myPaddle = GameObject.FindObjectOfType<paddle>();

        paddleToBallVector = this.transform.position - myPaddle.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

        if(!hasStarted) // if hasStarted == false 
        {
            this.transform.position = myPaddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;

                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            } 
        }

    }
}
