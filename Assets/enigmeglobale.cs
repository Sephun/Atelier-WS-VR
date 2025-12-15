using Unity.VisualScripting;
using UnityEngine;

public class enigmeglobale : MonoBehaviour
{
    public socket1 socket1;
    public socket2 socket2;
    public socket3 socket3;
    public Animator Animator;
    public void Update()
    {
        if ((socket1.triggercount1) && (socket2.triggercount2) && (socket3.triggercount3))
        {
            Animator.SetBool("Open", true);
        }
    }
}
