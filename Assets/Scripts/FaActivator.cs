using UnityEngine;
using System.Collections;

public class FaActivator : MonoBehaviour
{
    public bool IsFa;
    public EnigmeCarillon enigmeCarillon;
    public EnigmeCarillon2 enigmeCarillon2;
    public EnigmeCarillon3 enigmeCarillon3;

    public WhichStatuette whichStatuette;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && whichStatuette.statuette1)
        {
            enigmeCarillon.Notes("Fa");
            StartCoroutine(PutBoolTrue());
        }
        if (other.tag == "Player" && whichStatuette.statuette2)
        {
            enigmeCarillon2.Notes("Fa");
            StartCoroutine(PutBoolTrue());
        }
        if (other.tag == "Player" && whichStatuette.statuette3)
        {
            enigmeCarillon3.Notes("Fa");
            StartCoroutine(PutBoolTrue());
        }
    }

    public IEnumerator PutBoolTrue()
    {
        IsFa = true;
        yield return new WaitForSeconds(.5f);
        IsFa = false;
    }
}
