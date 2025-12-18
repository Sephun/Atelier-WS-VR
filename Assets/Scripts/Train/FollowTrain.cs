using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Unity.Mathematics;
using UnityEngine.XR.Interaction.Toolkit.Interactables;


public class FollowTrain : MonoBehaviour
{
    public List<GameObject> waypoints;
    public XRGrabInteractable xRGrab;
    public GameObject statuetteEnfant;
    public Rigidbody RBtraintoit;
    public float speedTrain = 2f;
    public float speedRotaTrain = .2f;  
    int index = 0;
    public Rigidbody rb;
    public bool isHit;
    public bool hasFall;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hasFall = false;
        xRGrab.enabled = false;
        statuetteEnfant.gameObject.SetActive(false);
        RBtraintoit.isKinematic = true;

    }


    // Update is called once per frame
    void Update()
    {
        if(!isHit && !hasFall)
        {
            Quaternion TargetRota1 = Quaternion.Euler(0f, -90f, 0f);
            Quaternion TargetRota2 = Quaternion.Euler(0f, 0, 0f);
            Quaternion TargetRota3 = Quaternion.Euler(0f, 90f, 0f);
            Quaternion TargetRota4 = Quaternion.Euler(0f, 180f, 0f);

            if(index == 1)
                {
                    this.transform.rotation = Quaternion.Slerp(this.transform.rotation, TargetRota1, Time.deltaTime * speedRotaTrain);
                    //this.transform.rotation = TargetRota;
                }
                else if(index == 3)
                {
                    this.transform.rotation = Quaternion.Slerp(this.transform.rotation, TargetRota2, Time.deltaTime * speedRotaTrain);
                }
                else if(index == 5)
                {
                    this.transform.rotation = Quaternion.Slerp(this.transform.rotation, TargetRota3, Time.deltaTime * speedRotaTrain);
                }
                else if(index == 7)
                {
                    this.transform.rotation = Quaternion.Slerp(this.transform.rotation, TargetRota4, Time.deltaTime * speedRotaTrain);
                }


                Vector3 destination = waypoints[index].transform.position;
                Vector3 newPos = Vector3.MoveTowards(this.transform.position, destination, speedTrain * Time.deltaTime);
                transform.position = newPos;

                float distance = Vector3.Distance(transform.position, destination);
                if(distance <= .1)
                {
                    if(index < waypoints.Count-1)
                    {
                        index++;
                    }
                    if (index == waypoints.Count-1)
                    {
                        Debug.Log("fein");
                        index = 0;
                    }
                }   
            
        }

        if(isHit && !hasFall)
        {
            hasFall = true;
        }

        if(hasFall)
        {
            xRGrab.enabled = true;
            isHit = false;
            RBtraintoit.useGravity = true;
            rb.useGravity = true;
            RBtraintoit.isKinematic = false;
            //StartCoroutine(Statuette1());
        }
    }

    // public IEnumerator Statuette1()
    // {
    //     yield return new WaitForSeconds(2f);

    // }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "BouleTrain")
        {
            isHit = true;
        }

        if(collision.gameObject.CompareTag("sol"))
        {
            statuetteEnfant.gameObject.SetActive(true);

        }
    }
}
