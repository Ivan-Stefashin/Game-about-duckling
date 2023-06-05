using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorter : MonoBehaviour
{
    private int sortingOrderBase = 0;
    private Renderer render;

    private void Awake()
    {
        render = GetComponent<Renderer>();


    }

    private void LateUpdate()
    {
        GetComponent<Renderer>().sortingOrderBase = (int)(sortingOrderBase - transform.position.y);


    }



}
