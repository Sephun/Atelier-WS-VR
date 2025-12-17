using UnityEngine;

public class A7 : MonoBehaviour
{
    public bool trigger7;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cercle 4"))
        {
            trigger7 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cercle 4"))
        {
            trigger7 = false;
        }
    }
}
