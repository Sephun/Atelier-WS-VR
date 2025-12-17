using UnityEngine;

public class Tige1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public A1 a1;
    public A2 a2;
    public A3 a3;
    public Verif verif;

    public bool decision1;

    public void Update()
    {
        if ((a1.trigger1) && (a2.trigger2) && (a3.trigger3) && (verif.triggercount == true))
        {
            decision1 = true;
        }
        else
        {
            decision1 = false;
        }
    }

}