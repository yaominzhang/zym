using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colum : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerCharacter>() != null)
        {
            GameMode.instance.ScoreUp();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
