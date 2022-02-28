using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    
    
    void Awake()
    {
        //Inheritance
        ShapeName = "cube";
        color = Color.blue;
        RotationAxis = "z";
    }

    public override void RotateShape()
    {
        gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * 100);
    }

}
