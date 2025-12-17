using UnityEngine;

public class socket1 : MonoBehaviour
{
    public bool triggercount1;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TrompeN"))
        {
            triggercount1 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TrompeN"))
        {
            triggercount1 = false;
        }
    }
}