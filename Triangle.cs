using System;
using System.Collections.Generic;
using System.Text;

class Triangle
{
    private float[] sideLength = new float[3]; 

        public Triangle(float sideA, float sideB, float sideC)
    {
        this.sideLength[0] = sideA;
        this.sideLength[1] = sideB;
        this.sideLength[2] = sideC;
    }
    public float GetSurface()
    {
        /*return width * height / 2;*/
        float s = (sideLength[0] + sideLength[1] + sideLength[2]) / 2;
        return MathF.Sqrt(s * (s - sideLength[0]) * (s - sideLength[1]) * (s - sideLength[2]));

    }
    
}
