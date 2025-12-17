using UnityEngine;

public class enigme1 : MonoBehaviour
{
    public Tige1 tige1;
    public Tige2 tige2;
    public Tige3 tige3;
    public Animator Animator;
    public void Update()
    {
        if ((tige1.decision1) && (tige2.decision2) && (tige3.decision3))
        {
            Animator.SetBool("ouverture", true);
        }
        else
        {
            Animator.SetBool("ouverture", false);
        }

    }
}
