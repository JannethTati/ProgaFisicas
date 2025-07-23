using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsBasics : MonoBehaviour
{
    //Attributes
    public Rigidbody playerRigidbody;
    public Rigidbody2D playerRigidbody2D;
    public float jumpForce ;
    public float speedMove = 200;
    public Detector detector;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void Update()
    {
        //Jump
        if (Input.GetKeyUp(KeyCode.Space) && detector.floorContact == true)
            playerRigidbody.AddForce(Vector3.up * jumpForce);
            //playerRigidbody.AddForce(0, 1000, 0);
    }

        // Update is called once per frame
        void FixedUpdate()
    {
        playerRigidbody.AddForce(Input.GetAxis("Horizontal") * speedMove, 0, Input.GetAxis("Vertical") * speedMove);
    }
}
