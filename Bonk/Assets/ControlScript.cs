using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidBody;

    private float acceleration = 5f;
    private float topSpeed = 10f;
    
    public float currentSpeed = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (currentSpeed < topSpeed)
            {
                currentSpeed += acceleration * Time.deltaTime;
            }
            myRigidBody.velocity = (Vector3.left * currentSpeed * Time.deltaTime);
        }
        else
        {
            currentSpeed = 0f;
        }
    }
}
