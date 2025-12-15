using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class BoiteAMusique2 : MonoBehaviour
{

    public GameObject OpenMusicBox2;
    public GameObject ClosedMusicBox2;
    public Vector3 ClosedBoxPos2;

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "BoiteMusique2")
        {
            ClosedBoxPos2 = ClosedMusicBox2.transform.position;
            StartCoroutine(MusicBox2());
        }

    }

    public IEnumerator MusicBox2()
    {
        yield return new WaitForSeconds(2f);
        ClosedMusicBox2.gameObject.SetActive(false);
        OpenMusicBox2.gameObject.SetActive(true);
        OpenMusicBox2.transform.position = ClosedBoxPos2;
    }

}
