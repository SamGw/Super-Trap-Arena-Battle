using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    public float min_x = -7f;
    public float max_x = -6f;
    public Vector2 velocity = new Vector2(0.4f, 0);
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(velocity);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2d.position.x <= min_x)
        {
            rb2d.velocity = velocity;
        }
        else if (rb2d.position.x >= max_x)
        {
            rb2d.velocity = -velocity;
        }
    }
}
