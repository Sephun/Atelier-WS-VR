using UnityEngine;

public class SiActivator : MonoBehaviour
{
    public GameObject Si;
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
