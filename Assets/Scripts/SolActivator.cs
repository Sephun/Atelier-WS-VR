using UnityEngine;

public class SolActivator : MonoBehaviour
{
    public GameObject Sol;
    public bool IsSol;
    public EnigmeCarillon enigmeCarillon;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            IsSol = true;
        }
        else
        {
            IsSol = false;
        }
    }
}
