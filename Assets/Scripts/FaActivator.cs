using UnityEngine;

public class FaActivator : MonoBehaviour
{
    public bool IsFa;
    public EnigmeCarillon enigmeCarillon;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enigmeCarillon.Notes("Fa");
        }
    }
}
