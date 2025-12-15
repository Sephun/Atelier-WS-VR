using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class BoiteAMusique3 : MonoBehaviour
{
    public GameObject OpenMusicBox3;
    public GameObject ClosedMusicBox3;
    public Vector3 ClosedBoxPos3;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BoiteMusique3")
        {
            ClosedBoxPos3 = ClosedMusicBox3.transform.position;
            StartCoroutine(MusicBox3());
        }

    }

    public IEnumerator MusicBox3()
    {
        yield return new WaitForSeconds(2f);
        ClosedMusicBox3.gameObject.SetActive(false);
        OpenMusicBox3.gameObject.SetActive(true);
        OpenMusicBox3.transform.position = ClosedBoxPos3;
    }

}
