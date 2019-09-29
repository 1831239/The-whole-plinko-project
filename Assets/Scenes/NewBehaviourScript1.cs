using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer sr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        //for keys
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        //        collision.gameObject.GetComponent<Rigidbody2D>().color = Color.blue;
        //collision.gameObject.GetComponent<Renderer>().material.color = new Color();

        Debug.Log("Object collided" + collision.gameObject.name);
    }
}
