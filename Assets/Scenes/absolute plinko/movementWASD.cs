using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementWASD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 50f); 
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 50f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 50f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 50f);
        }
    }
}
