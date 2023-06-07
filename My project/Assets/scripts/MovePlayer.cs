using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public Animator anim;
    public float speed;
    private Vector2 derection;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        derection.x = Input.GetAxisRaw("Horizontal");
        derection.y = Input.GetAxisRaw("Vertical");
        anim.SetFloat("Horizontal",derection.x);
        //anim.SetFloat("Vertical",derection.y);
        anim.SetFloat("Speed",derection.sqrMagnitude);
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + derection * speed * Time.fixedDeltaTime);
        
    }
}
