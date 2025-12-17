using UnityEngine;

public class A5 : MonoBehaviour
{
    public bool trigger5;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cercle 6"))
        {
            trigger5 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cercle 6"))
        {
            trigger5 = false;
        }
    }
}
