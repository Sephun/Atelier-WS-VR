using JetBrains.Annotations;
using Mono.Cecil.Cil;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnigmeCarillon : MonoBehaviour
{
    public GameObject Do;
    public GameObject Re;
    public GameObject Mi;
    public GameObject Fa;
    public GameObject Sol;
    public GameObject La;
    public GameObject Si;

    //public bool isDo;
    //public bool isRe;
    //public bool isMi;
    //public bool isFa;
    //public bool isSol;
    //public bool isLa;
    //public bool isSi;
 
    public GameObject Statuette1;

    public DoActivate doActivate;
    public ReActivate reActivate;
    public MiActivator miActivator;
    public FaActivator FaActivator;
    public SolActivator SolActivator;
    public LaActivator LaActivator;
    public SiActivator SiActivator;

    public static string GoodNotes = "DoReFaMiSiSol"; //La bonne combinaison à écrire
    public static List<string> TypedNotes = [null, null, null, null, null, null];
    public static int NoteTyped = 0;

    public void Notes(string note)
    {
        



    }

}
