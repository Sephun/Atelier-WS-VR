using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class BoiteAMusique : MonoBehaviour
{

    public OpenMusicBox openMusicBox;
    public bool IsBox1;
    public AudioSource audioSource;

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "BoiteMusique1")
        {
            IsBox1 = true;
            audioSource.Play();
        }
        else
        {
            IsBox1 = false;
        }
    }

}
