using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    [SerializeField]
    public AudioSource DoSound;

    public void OnTriggerEnter(Collider Player)
    {
            DoSound.Play();       
    }
}
