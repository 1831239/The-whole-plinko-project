using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourchange : MonoBehaviour
{
    public SpriteRenderer ColorChangingTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            ColorChangingTarget.color = Random.ColorHSV();
        }
    }
}
