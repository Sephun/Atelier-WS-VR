using UnityEngine;

public class FaActivator : MonoBehaviour
{
    public GameObject Fa;
    public bool IsFa;
    public EnigmeCarillon enigmeCarillon;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            IsFa = true;
        }
        else
        {
            IsFa = false;
        }
    }
}
