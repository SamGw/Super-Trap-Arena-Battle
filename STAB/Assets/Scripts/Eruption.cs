using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour
{
    private Animator anim;
    public GameObject Meteorite;
    private float timer = 0.0f;

    private Random ran;
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
            Instantiate(Meteorite, new Vector3(Random.Range(-6,6),10,0),new Quaternion(0f,0f,0f,0f));
        }
        
    }
}
