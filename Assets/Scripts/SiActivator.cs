using UnityEngine;
using System.Collections;

public class SiActivator : MonoBehaviour
{
    public bool IsSi;
    public EnigmeCarillon enigmeCarillon;
    public EnigmeCarillon2 enigmeCarillon2;
    public EnigmeCarillon3 enigmeCarillon3;

    public WhichStatuette whichStatuette;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && whichStatuette.statuette1)
        {
            enigmeCarillon.Notes("Si");
            StartCoroutine(PutBoolTrue());
        }
        if (other.tag == "Player" && whichStatuette.statuette2)
        {
            enigmeCarillon2.Notes("Si");
            StartCoroutine(PutBoolTrue());
        }
        if (other.tag == "Player" && whichStatuette.statuette3)
        {
            enigmeCarillon3.Notes("Si");
            StartCoroutine(PutBoolTrue());
        }
    }

    public IEnumerator PutBoolTrue()
    {
        IsSi = true;
        yield return new WaitForSeconds(.5f);
        IsSi = false;
    }
}
