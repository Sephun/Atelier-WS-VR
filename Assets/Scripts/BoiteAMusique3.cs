using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class BoiteAMusique3 : MonoBehaviour
{
    public OpenMusicBox openMusicBox;
    public bool IsBox3;

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "BoiteMusique3")
        {
            IsBox3 = true;
        }
        else
        {
            IsBox3 = false;
        }
    }

}
