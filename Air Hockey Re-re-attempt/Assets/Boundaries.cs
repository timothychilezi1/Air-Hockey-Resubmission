using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    [SerializeField]
    float up, down, left, right;

    private void Update()
    {
        Vector3 Temp = transform.position;  
        if(Temp.x > right)
            Temp.x = right;
        if (Temp.x < left)  
            Temp.x = left;
        if (Temp.y > up)    
            Temp.y = up;
        if (Temp.y < down)  
            Temp.y = down;

        transform.position = Temp;
    }
}
