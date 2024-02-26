using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidBody;

    private float acceleration = 0.5f;
    public float lift = 1f;
    private float topSpeed = 10f;

    private bool onGround = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && myRigidBody.velocity.x > -topSpeed)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x-acceleration, myRigidBody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && myRigidBody.velocity.x < topSpeed)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x + acceleration, myRigidBody.velocity.y);
        }
        
        if (Input.GetKey(KeyCode.UpArrow) && onGround)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, lift);
        }
    }
}
