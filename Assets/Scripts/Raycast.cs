using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(0, 100 * Time.deltaTime, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward, Color.black);
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
            print("Hit! " + hit.collider.name);
            // print("Point: " + hit.point);
            //print("Normal: " + hit.normal);
            //print("RB! " + hit.rigidbody);
        }

        //      if (Physics.SphereCast(transform.position, 1, transform.forward, out hit))
        //{
        //          print("Sphere Hit! " + hit.collider.name);
        //      }
    }
}
