using UnityEngine;

public class DoActivate : MonoBehaviour
{
    public bool IsDo;
    public EnigmeCarillon enigmeCarillon;
    public EnigmeCarillon2 enigmeCarillon2;
    public EnigmeCarillon3 enigmeCarillon3;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enigmeCarillon.Notes("Do");
            enigmeCarillon2.Notes2("Do");
        }
    }
}
