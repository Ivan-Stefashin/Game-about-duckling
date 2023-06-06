using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer : MonoBehaviour
{
    public bool isStatic = false;
    public  float offset = 0;
    private int sortingOrderBase =0;
    private Renderer rend;

    private void Awake() {
        rend = GetComponent<Renderer>();

    }

    private void LateUpdate() {
        rend.sortingOrder = (int)(sortingOrderBase - transform.position.y + offset);

        if(isStatic)
        Destroy(this);
            
    

    }
}
