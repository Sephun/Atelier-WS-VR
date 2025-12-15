using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Derouillage : MonoBehaviour
{

    public bool isTrompe;
    public bool ispilule;
    public GameObject trompe;
    public GameObject trompeneuve;

    public void Start()
    {
        trompeneuve.gameObject.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Trompe"))
        {
            Debug.Log("C'est bon");
            isTrompe = true;
            

        }

        if (other.CompareTag("Pillule"))
        {
            Debug.Log("pilululue");
            ispilule = true;

        }



    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Trompe"))
        {
            Debug.Log("C'est bon");
            isTrompe = false;

            if (other.CompareTag("Pillule"))
            {
                Debug.Log("pilululue");
                ispilule = true;

            }

        }
    }

    public void Update()
    {
        if((isTrompe) && (ispilule))
        {
            settrompeneuve();
            isTrompe = false;
            ispilule = false;
            
        }
    }

    public void settrompeneuve()
    {
        trompeneuve.gameObject.SetActive(true);
        trompeneuve.transform.position = trompe.transform.position;
        trompe.gameObject.SetActive(false);
        Debug.Log("Ya les 2");
    }
}
