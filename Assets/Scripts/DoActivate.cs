using UnityEngine;
using System.Collections;

public class DoActivate : MonoBehaviour
{
    public bool IsDo;
    public EnigmeCarillon enigmeCarillon;
    public EnigmeCarillon2 enigmeCarillon2;
    public EnigmeCarillon3 enigmeCarillon3;

    public WhichStatuette whichStatuette;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && whichStatuette.statuette1)
        {
            enigmeCarillon.Notes("Do");
            StartCoroutine(PutBoolTrue());
        }
        if (other.tag == "Player" && whichStatuette.statuette2)
        {
            enigmeCarillon2.Notes("Do");
            StartCoroutine(PutBoolTrue());
        }
        if (other.tag == "Player" && whichStatuette.statuette3)
        {
            enigmeCarillon3.Notes("Do");
            StartCoroutine(PutBoolTrue());
        }
    }

    public IEnumerator PutBoolTrue()
    {
        IsDo = true;
        yield return new WaitForSeconds(.5f);
        IsDo = false;
    }
}
