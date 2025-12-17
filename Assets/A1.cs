using UnityEngine;

public class A1 : MonoBehaviour
{
    public bool trigger1;
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cercle 10"))
        {
            trigger1 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cercle 10"))
        {
            trigger1 = false;
        }
    }
}
