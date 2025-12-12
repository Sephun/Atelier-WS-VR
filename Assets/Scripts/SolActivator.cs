using System.Collections;
using UnityEngine;

public class SolActivator : MonoBehaviour
{
    public bool IsSol;
    public EnigmeCarillon enigmeCarillon;
    public EnigmeCarillon2 enigmeCarillon2;
    public EnigmeCarillon3 enigmeCarillon3;

    public WhichStatuette whichStatuette;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && whichStatuette.statuette1)
        {
            enigmeCarillon.Notes("Sol");
            StartCoroutine(PutBoolTrue());
        }
        if (other.tag == "Player" && whichStatuette.statuette2)
        {
            enigmeCarillon2.Notes("Sol");
            StartCoroutine(PutBoolTrue());
        }
        if (other.tag == "Player" && whichStatuette.statuette3)
        {
            enigmeCarillon3.Notes("Sol");
            StartCoroutine(PutBoolTrue());
        }
    }

    public IEnumerator PutBoolTrue()
    {
        IsSol = true;
        yield return new WaitForSeconds(.5f);
        IsSol = false;
    }

}
