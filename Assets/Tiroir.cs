using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Tiroir : MonoBehaviour
{
    public GameObject tiroir;
    public int triggercount=0;
    public Animation open;

    public void Update()
    {
        Ouvrir();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TrompeN"))
        {
            triggercount += 1;
        }
        if (other.CompareTag("Bague"))
        {
            triggercount += 1;
        }
        if (other.CompareTag("Voiture"))
        {
            triggercount += 1;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TrompeN"))
        {
            triggercount -= 1;
        }
        if (other.CompareTag("Bague"))
        {
            triggercount -= 1;
        }
        if (other.CompareTag("Voiture"))
        {
            triggercount -= 1;
        }
    }
    public void Ouvrir()
    {
        if (triggercount >= 3)
        {
            open.Play();
            open.Stop();
            triggercount = 0;
        }
    }
}
