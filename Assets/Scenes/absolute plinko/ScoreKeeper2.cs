using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper2 : MonoBehaviour
{
    private int score = 0;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncrementScore(int val)
    {
        score += val;
        text.GetComponent<UnityEngine.UI.Text>().text = "Score : " + score.ToString();
    }
}
