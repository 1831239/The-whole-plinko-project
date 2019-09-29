using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addscore : MonoBehaviour
{
    // Start is
    //called before the first frame update
    public ScoreKeeper2 score;
    public int pointsFromScquare;
    //if()
    private void OnCollisionEnter2D(Collision2D collision)
    {
        score.IncrementScore(pointsFromScquare);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
