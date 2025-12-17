using UnityEngine;

public class OpenMusicBox : MonoBehaviour
{

    public Animator openMusicBox;
    public Animator ifMusicBox;
    public BoiteAMusique boiteAMusique;
    public BoiteAMusique2 boiteAMusique2;
    public BoiteAMusique3 boiteAMusique3;
    public BoiteAMusique4 boiteAMusique4;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MusicBoxCollider4") && (boiteAMusique4.IsBox4))
        {
            openMusicBox.SetBool("openMusicBox", true);
        }

        if (other.CompareTag("MusicBoxCollider1") && (boiteAMusique.IsBox1))
        {
            openMusicBox.SetBool("openMusicBox", true);
            ifMusicBox.SetBool("ifmusicbox", true);
        }

        if (other.CompareTag("MusicBoxCollider2") && (boiteAMusique2.IsBox2))
        {
            openMusicBox.SetBool("openMusicBox", true);
        }
        if (other.CompareTag("MusicBoxCollider3") && (boiteAMusique3.IsBox3))
        {
            openMusicBox.SetBool("openMusicBox", true);
        }

    }

}
