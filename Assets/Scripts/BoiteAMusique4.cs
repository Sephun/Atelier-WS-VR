using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class BoiteAMusique4 : MonoBehaviour
{

    public OpenMusicBox openMusicBox;
    public bool IsBox4;

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "BoiteMusique4")
        {
           IsBox4 = true;
        }
        else
        {
            IsBox4 = false;
        }
    }
}
