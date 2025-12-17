using UnityEngine;

public class A2 : MonoBehaviour
{
    public bool trigger2;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cercle 9"))
        {
            trigger2 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cercle 9"))
        {
            trigger2 = false;
        }
    }

}
