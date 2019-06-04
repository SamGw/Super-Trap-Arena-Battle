using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeMovements : MonoBehaviour
{
    public float direction;
    private Rigidbody2D rb2d;
    private Transform tr;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        rb2d.velocity = new Vector2(direction*6f, 0f);
        
        tr.localScale = new Vector3(direction * tr.localScale.x, tr.localScale.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }
    }
}
