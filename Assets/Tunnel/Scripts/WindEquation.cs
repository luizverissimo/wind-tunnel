using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class WindEquation : MonoBehaviour {

    public float crossSectional = 0.49f;
    public float density = 1.1614f;
    public float hydraulicDiameter = 0.7f;
    public float Diameter = 0.1f;
    public float viscosity = 0.861029792f;
    public float mi = 0.00001846f;
    public float Rugosity = 0.00026f;
    public float relativeRugosity = 0.00037143f;
    public float reynolds = 264240.52f;
    public float length = 2f;
    public float dragRate = 0.28f;
    public float projectedArea = 0.007853982f;
    //public const Double liftRate = 0.23f;
    public float speed = 6;

 
    void Update() {

    }

    public Double volumetricFlow(Double speed)
    {
        return (speed * crossSectional);
    }

    public Double massFlow(Double speed)
    {
        return (speed * crossSectional) / viscosity ;
    }


    public Double DynamicPressure(Double speed)
    {
       return (Math.Pow(speed, 2) * density) / 2;
    }

    public Double ReynoldsNumber(Double speed)
    {
        return (density * speed * hydraulicDiameter) / mi;
    }

    public Double frictionFactor(Double speed)
    {
        return 0.25 * Math.Pow(( Math.Log10(((relativeRugosity)/3.7)+(5.74/Math.Pow(reynolds,0.9)))),-2);
    }

    public Double chargeLoss(Double speed)
    {
        return (frictionFactor(speed) * ((density * length * Math.Pow(speed, 2)) / (2 * hydraulicDiameter)));
    }

    public Double drag(Double speed)
    {
        return dragRate * ((density * projectedArea * Math.Pow(speed,2))/2);
    }

    

}
