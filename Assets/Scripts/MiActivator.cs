using UnityEngine;

public class MiActivator : MonoBehaviour
{
    public bool IsMi;
    public EnigmeCarillon enigmeCarillon;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enigmeCarillon.Notes("Mi");
        }
    }
}
