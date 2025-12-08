using UnityEngine;

public class MiActivator : MonoBehaviour
{
    public GameObject Mi;
    public bool IsMi;
    public EnigmeCarillon enigmeCarillon;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            IsMi = true;
        }
        else
        {
            IsMi = false;
        }
    }
}
