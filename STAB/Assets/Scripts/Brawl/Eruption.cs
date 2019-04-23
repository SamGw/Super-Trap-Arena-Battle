<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour
{
    private Animator anim;
    
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetFloat("timer", timer);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        anim.SetFloat("timer", timer);
        if (timer > 5.5)
        {
            timer = 0;
        }
        
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour
{
    private Animator anim;
    
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetFloat("timer", timer);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        anim.SetFloat("timer", timer);
        if (timer > 5.5)
        {
            timer = 0;
        }
        
    }
}
>>>>>>> d624f5ee2f32a5cd69ffffd25e44f7c22a46e2d7
