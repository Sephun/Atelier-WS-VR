using UnityEngine;

public class CarillonCheck : MonoBehaviour
{
    public EnigmeCarillon enigmeCarillon;
    public EnigmeCarillon2 enigmeCarillon2;
    public EnigmeCarillon3 enigmeCarillon3;
    public Animator animator;

    public bool carillon1OK;
    public bool carillon2OK;
    public bool carillon3OK;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enigmeCarillon.isFinished1)
        {
            carillon1OK = true;
        }

        if(enigmeCarillon2.isFinished2)
        {
            carillon2OK = true;
        }

        if(enigmeCarillon3.isFinished3)
        {
            carillon3OK = true;
        }

        if(carillon1OK && carillon2OK && carillon3OK)
        {
            animator.SetBool("OpenDoor", true);
        }
    }
}
