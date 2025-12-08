using UnityEngine;

public class SolActivator : MonoBehaviour
{
    public bool IsSol;
    public EnigmeCarillon enigmeCarillon;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enigmeCarillon.Notes("Si");
        }
    }
}
