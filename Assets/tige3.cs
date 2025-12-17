using UnityEngine;

public class Tige3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public A8 a8;
    public A9 a9;
    public A10 a10;
    public Verif3 verif3;

    public bool decision3;

    public void Update()
    {
        if ((a8.trigger8) && (a9.trigger9) && (a10.trigger10) && (verif3.triggercount3))
        {
            decision3 = true;
        }
        else
        {
            decision3 = false;
        }
    }
}