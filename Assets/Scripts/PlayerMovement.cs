using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
	
	// Update is called once per frame
	void Update () //Always use FixUpdate when using Physics
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Use Time.delaTime to make frame rate and force equal\

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //To remove delay and momentum of player
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        else if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

    }
}
