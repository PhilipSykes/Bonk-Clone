using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{
    public ControlScript player;
    public bool onGround = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != 3)
        {
            player.SetOnGround(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        player.SetOnGround(false);
    }
}
