using UnityEngine;

public class SiActivator : MonoBehaviour
{
    public bool IsSi;
    public EnigmeCarillon enigmeCarillon;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enigmeCarillon.Notes("Si");
        }
    }
}
