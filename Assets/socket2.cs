using UnityEngine;

public class socket2 : MonoBehaviour
{
    public bool triggercount2;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bague"))
        {
            triggercount2 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bague"))
        {
            triggercount2 = false;
        }
    }
}
