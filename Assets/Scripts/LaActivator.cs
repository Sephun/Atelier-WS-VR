using UnityEngine;

public class LaActivator : MonoBehaviour
{
    public GameObject La;
    public bool IsLa;
    public EnigmeCarillon enigmeCarillon;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enigmeCarillon.Notes("La");
        }
    }
}
