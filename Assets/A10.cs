using UnityEngine;

public class A10 : MonoBehaviour
{
    public bool trigger10;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cercle 1"))
        {
            trigger10 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cercle 1"))
        {
            trigger10 = false;
        }
    }
}
