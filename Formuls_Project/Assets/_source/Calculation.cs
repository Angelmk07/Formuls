using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculation : MonoBehaviour
{
    public static float formula1(float m)
    {
        return m * (So_constant.LightSpeed^ 2);
    }
    public static float formula2(float ρ, float V)
    {
        return ρ * So_constant.GValue*V;
    }
    public static float formula3(float ρ, float h)
    {
        return ρ * So_constant.GValue * h;
    }
    public static float formula4(float m,float a)
    {
        return m + (So_constant.GValue + a);
    }
    public static float formula5(int t)
    {
        return So_constant.GValue * (t ^ 2) / 2;
    }

}
