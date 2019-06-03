using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    // Start is called before the first frame update
    public int max = 50;
    private int current;
    private SpriteRenderer spriterenderer;
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        current = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (current == max)
        {
            // son detruit
            Destroy(gameObject);
        }
        Debug.Log(current);
    }

    void Disappear()
    {
        spriterenderer.color = new Color(1f, 1f, 1f, (float)(max - current)/max);
    }
    
    void OnCollisionEnter2D (Collision2D coll)
    {
        if (!coll.collider.CompareTag("Ground"))
        {
            current++;
            Disappear();
        }
    }
}
