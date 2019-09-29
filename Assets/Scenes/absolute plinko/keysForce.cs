using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keysForce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        var theRigidBody = this.GetComponent<Rigidbody2D>();



        if (Input.GetKey(KeyCode.W))
        {
            theRigidBody.AddForce(transform.forward * 5,
            ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            theRigidBody.AddForce(transform.right * 5,
            ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            theRigidBody.AddForce(-transform.right * 5,
                        ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            theRigidBody.AddForce(-transform.forward * 5,
                        ForceMode2D.Impulse);
        }
    }
}
