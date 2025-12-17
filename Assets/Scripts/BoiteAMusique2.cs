using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class BoiteAMusique2 : MonoBehaviour
{

    public OpenMusicBox openMusicBox;
    public bool IsBox2;

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "BoiteMusique2")
        {
            IsBox2 = true;
        }
        else
        {
            IsBox2 = false;
        }
    }
}
