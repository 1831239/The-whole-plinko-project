using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerscore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Scoreholder sh;
    private void OnCollisionEnter2D(Collision2D collision)
    {
       // sh.IncrementScore();
    }
}
