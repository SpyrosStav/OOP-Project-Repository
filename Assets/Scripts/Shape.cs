using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    //Encapsulation
    protected Color color {get;set;}
    protected string ShapeName {get;set;}
    protected string RotationAxis {get;set;}
    protected bool isRotating = false;

    void Start()
    {
        ApplyColor();
    }

    void Update()
    {
        if(isRotating) RotateShape();
        
    }

    void OnMouseDown()
    {
        Debug.Log("Ouch! you hit a " + ShapeName + " and it rotates around the " + RotationAxis + " axis");
        isRotating = true;
    }

    //Abstraction
    void ApplyColor()
    {
        var render = gameObject.GetComponent<Renderer>();
        render.material.SetColor("_Color", color);
    }
    //Polymorphism
    public virtual void RotateShape(){}
}
