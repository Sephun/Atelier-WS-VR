using Unity.VisualScripting;
using UnityEngine;

public class Verif : MonoBehaviour
{
    public bool triggercount;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cercle 1") || other.CompareTag("Cercle 2") || other.CompareTag("Cercle 3") || other.CompareTag("Cercle 4") || other.CompareTag("Cercle 5") || other.CompareTag("Cercle 6") || other.CompareTag("Cercle 7") || other.CompareTag("Cercle 8") || other.CompareTag("Cercle 9") || other.CompareTag("Cercle 10"))
        {
            triggercount = false;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cercle 1") || other.CompareTag("Cercle 2") || other.CompareTag("Cercle 3") || other.CompareTag("Cercle 4") || other.CompareTag("Cercle 5") || other.CompareTag("Cercle 6") || other.CompareTag("Cercle 7") || other.CompareTag("Cercle 8") || other.CompareTag("Cercle 9") || other.CompareTag("Cercle 10"))
        {
            triggercount = true; ;
        }
    }

}
