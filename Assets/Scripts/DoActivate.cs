using UnityEngine;

public class DoActivate : MonoBehaviour
{
    public bool IsDo;
    public EnigmeCarillon enigmeCarillon;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enigmeCarillon.Notes("Do");
        }
    }
}
