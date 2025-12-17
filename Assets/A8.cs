using UnityEngine;

public class A8 : MonoBehaviour
{
    public bool trigger8;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cercle 3"))
        {
            trigger8 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cercle 3"))
        {
            trigger8 = false;
        }
    }
}
