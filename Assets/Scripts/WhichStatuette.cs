using NUnit.Framework.Interfaces;
using UnityEngine;

public class WhichStatuette : MonoBehaviour
{

    public bool statuette1;
    public bool statuette2;
    public bool statuette3;

    public EnigmeCarillon enigmeCarillon;
    public EnigmeCarillon2 enigmeCarillon2;
    public EnigmeCarillon3 enigmeCarillon3;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Statuette1")
        {
            enigmeCarillon.enabled = true;
            enigmeCarillon2.enabled = false;
            enigmeCarillon3.enabled = false;

        }
        if (other.tag == "Statuette2")
        {
            enigmeCarillon2.enabled = true;
            enigmeCarillon.enabled = false;
            enigmeCarillon3.enabled = false;
        }
        if (other.tag == "Statuette3")
        {
            enigmeCarillon3.enabled = true;
            enigmeCarillon.enabled = false;
            enigmeCarillon2.enabled = false;
        }
    }
}
