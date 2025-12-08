using UnityEngine;

public class ReActivate : MonoBehaviour
{
    public GameObject Re;
    public bool IsRe;
    public EnigmeCarillon enigmeCarillon;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enigmeCarillon.Notes("Re");
        }
    }
}
