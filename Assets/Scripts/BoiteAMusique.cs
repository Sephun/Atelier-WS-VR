using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class BoiteAMusique : MonoBehaviour
{

    public GameObject OpenMusicBox1;
    public GameObject ClosedMusicBox1;
    public Vector3 ClosedBoxPos1;


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BoiteMusique1")
        {
            ClosedBoxPos1 = ClosedMusicBox1.transform.position;
            StartCoroutine(MusicBox1());
        }
        
    }

    public IEnumerator MusicBox1()
    {
        yield return new WaitForSeconds(2f);
        ClosedMusicBox1.gameObject.SetActive(false);
        OpenMusicBox1.gameObject.SetActive(true);
        OpenMusicBox1.transform.position = ClosedBoxPos1;
    }

}
