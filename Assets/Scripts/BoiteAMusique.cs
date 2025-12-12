using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class BoiteAMusique : MonoBehaviour
{

    public GameObject OpenMusicBox1;
    public GameObject OpenMusicBox2;
    public GameObject OpenMusicBox3;
    public GameObject OpenMusicBox4;
    public GameObject ClosedMusicBox1;
    public GameObject ClosedMusicBox2;
    public GameObject ClosedMusicBox3;
    public GameObject ClosedMusicBox4;
    public Vector3 ClosedBoxPos1;
    public Vector3 ClosedBoxPos2;
    public Vector3 ClosedBoxPos3;
    public Vector3 ClosedBoxPos4;

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "BoiteMusique1")
        {
            ClosedBoxPos1 = ClosedMusicBox1.transform.position;
            StartCoroutine(MusicBox1());

        }
        if (other.tag == "BoiteMusique2")
        {
            ClosedBoxPos2 = ClosedMusicBox2.transform.position;
            StartCoroutine(MusicBox2());
        }
        if (other.tag == "BoiteMusique3")
        {
            ClosedBoxPos3 = ClosedMusicBox3.transform.position;
            StartCoroutine(MusicBox3());
        }
        if (other.tag == "BoiteMusique4")
        {
            ClosedBoxPos4 = ClosedMusicBox4.transform.position;
            StartCoroutine(MusicBox4());
        }
        
    }

    public IEnumerator MusicBox1()
    {
        yield return new WaitForSeconds(2f);
        ClosedMusicBox1.gameObject.SetActive(false);
        OpenMusicBox1.gameObject.SetActive(true);
        OpenMusicBox1.transform.position = ClosedBoxPos1;
    }

    public IEnumerator MusicBox2()
    {
        yield return new WaitForSeconds(2f);
        ClosedMusicBox2.gameObject.SetActive(false);
        OpenMusicBox2.gameObject.SetActive(true);
        OpenMusicBox2.transform.position = ClosedBoxPos2;
    }

    public IEnumerator MusicBox3()
    {
        yield return new WaitForSeconds(2f);
        ClosedMusicBox3.gameObject.SetActive(false);
        OpenMusicBox3.gameObject.SetActive(true);
        OpenMusicBox3.transform.position = ClosedBoxPos3;
    }

    public IEnumerator MusicBox4()
    {
        yield return new WaitForSeconds(2f);
        ClosedMusicBox4.gameObject.SetActive(false);
        OpenMusicBox4.gameObject.SetActive(true);
        OpenMusicBox4.transform.position = ClosedBoxPos4;
    }

}
