using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    private Transform trans;
    public GameObject obj;


    // Start is called before the first frame update
    void Start()
    {
       // trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetKeyUp (KeyCode.D)) 
         {
             obj.Position.x = ;
         }
         */
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }
}
