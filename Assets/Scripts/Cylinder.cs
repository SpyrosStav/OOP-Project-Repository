using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    // Start is called before the first frame update
    void Awake()
    {
        //Inheritence
        ShapeName = "cylinder";
        color = Color.red;
        RotationAxis = "x";
    }

    public override void RotateShape()
    {
        gameObject.transform.Rotate(Vector3.right * Time.deltaTime * 100);
    }
}
