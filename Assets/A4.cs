using UnityEngine;

public class A4 : MonoBehaviour
{
    public bool trigger4;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cercle 7"))
        {
            trigger4 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cercle 7"))
        {
            trigger4 = false;
        }
    }
}
