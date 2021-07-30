using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeate : MonoBehaviour
{
    BoxCollider2D groundcollider;
    float groundHoizontalLength;
    // Start is called before the first frame update
    void Start()
    {
        groundcollider = GetComponent<BoxCollider2D>();
        groundHoizontalLength = groundcollider.size.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHoizontalLength)
        {
            Vector2 offset = new Vector2(groundHoizontalLength * 2f, 0);
            transform.position = (Vector2)transform.position + offset;
        }

        
        }
}
