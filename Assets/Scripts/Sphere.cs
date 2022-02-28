using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    // Start is called before the first frame update
    void Awake()
    {
        //Inheritence
        ShapeName = "sphere";
        color = Color.green;
        RotationAxis = "y";
    }

    public override void RotateShape()
    {
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * 100);
    }
}
