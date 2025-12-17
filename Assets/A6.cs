using UnityEngine;

public class A6 : MonoBehaviour
{
    public bool trigger6;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cercle 5"))
        {
            trigger6 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cercle 5"))
        {
            trigger6 = false;
        }
    }
}
