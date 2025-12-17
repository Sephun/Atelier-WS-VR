using UnityEngine;

public class Tige2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public A4 a4;
    public A5 a5;
    public A6 a6;
    public A7 a7;
    public Verif2 verif2;

    public bool decision2;

    public void Update()
    {
        if ((a4.trigger4) && (a5.trigger5) && (a6.trigger6) && (a7.trigger7) && (verif2.triggercount2) )
        {
            decision2 = true;
        }
        else
        {
            decision2 = false;
        }
    }
}