using UnityEngine;

public class Sifflet : MonoBehaviour
{

    public AudioSource sifflet;


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Locomotive"))
        {
            sifflet.Play();
        }
    }
}
