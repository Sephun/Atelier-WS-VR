using UnityEngine;

public class A3 : MonoBehaviour
{
    public bool trigger3;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cercle 8"))
        {
            trigger3 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cercle 8"))
        {
            trigger3 = false;
        }
    }
}
