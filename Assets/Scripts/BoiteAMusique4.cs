using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class BoiteAMusique4 : MonoBehaviour
{
    public GameObject OpenMusicBox4;
    public GameObject ClosedMusicBox4;
    public Vector3 ClosedBoxPos4;

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "BoiteMusique4")
        {
            ClosedBoxPos4 = ClosedMusicBox4.transform.position;
            StartCoroutine(MusicBox4());
        }

    }
    public IEnumerator MusicBox4()
    {
        yield return new WaitForSeconds(2f);
        ClosedMusicBox4.gameObject.SetActive(false);
        OpenMusicBox4.gameObject.SetActive(true);
        OpenMusicBox4.transform.position = ClosedBoxPos4;
    }

}
