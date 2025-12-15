using UnityEngine;

public class socket3 : MonoBehaviour
{
    public bool triggercount3;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Voiture"))
        {
            triggercount3 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Voiture"))
        {
            triggercount3 = false;
        }
    }
}