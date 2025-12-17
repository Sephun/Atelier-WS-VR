using UnityEngine;

public class A9 : MonoBehaviour
{
    public bool trigger9;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cercle 2"))
        {
            trigger9 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cercle 2"))
        {
            trigger9 = false;
        }
    }
}
