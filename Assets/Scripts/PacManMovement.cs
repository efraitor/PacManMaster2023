using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManMovement : MonoBehaviour
{
    //Velocidad de PacMan
    public float speed = 0.4f;
    //Referencia al RigidBody
    public Rigidbody2D theRB;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            theRB.velocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            theRB.velocity = new Vector2(speed, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            theRB.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            theRB.velocity = new Vector2(0f, -speed);
        }
    }


}
