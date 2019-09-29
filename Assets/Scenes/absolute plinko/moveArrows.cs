using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveArrows : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float factor = 6f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * Time.deltaTime * factor;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * Time.deltaTime * factor;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime * factor;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * Time.deltaTime * factor;
        }
    }
}
