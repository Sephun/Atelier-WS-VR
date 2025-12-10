using System;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeCarillon2 : MonoBehaviour
{
    public GameObject Do;
    public GameObject Re;
    public GameObject Mi;
    public GameObject Fa;
    public GameObject Sol;
    public GameObject La;
    public GameObject Si;

    public DoActivate doActivate;
    public ReActivate reActivate;
    public MiActivator miActivator;
    public FaActivator faActivator;
    public SolActivator solActivator;
    public LaActivator laActivator;
    public SiActivator siActivator;

    public bool DoMi;
    public bool MiDo;
    public bool MiSol;
    public bool SolMi;
    public bool SiDo;
    public bool DoSi;
    public bool SolRe;
    public bool ReSol;
    public bool MiSi;
    public bool SiMi;
    public bool LaRe;
    public bool ReLa;
    public bool FaRe;
    public bool ReFa;
    public bool ReSi;
    public bool SiRe;

    public List<string> TypedNotesS2 = new List<string>(9);
    public int NoteTyped = 0;

    public string GoodNotes2 = "MiSolFaReReLaLaSolDo";
    public string GoodNotes2_1 = "SolMiReFaLaReLaSolDo";

    public void Awake()
    {
        TypedNotesS2[0] = "null";
        TypedNotesS2[1] = "null";
        TypedNotesS2[2] = "null";
        TypedNotesS2[3] = "null";
        TypedNotesS2[4] = "null";
        TypedNotesS2[5] = "null";
        TypedNotesS2[6] = "null";
        TypedNotesS2[7] = "null";
        TypedNotesS2[8] = "null";
    }

    public void Update()
    {
        if (doActivate.IsDo && miActivator.IsMi)
        {
            DoMi = true;
            MiDo = true;
        }
        if (reActivate.IsRe && siActivator.IsSi)
        {
            ReSi = true;
            SiRe = true;
        }
        if (miActivator.IsMi && solActivator.IsSol)
        {
            MiSol = true;
            SolMi = true;
        }
        if (faActivator.IsFa && reActivate.IsRe)
        {
            FaRe = true;
            ReFa = true;
        }
        if (reActivate.IsRe && laActivator.IsLa)
        {
            ReLa = true;
            LaRe = true;
        }
        if (miActivator.IsMi && siActivator.IsSi)
        {
            MiSi = true;
            SiMi = true;
        }
        if (solActivator.IsSol && reActivate.IsRe)
        {
            SolRe = true;
            ReSol = true;
        }
        if (siActivator.IsSi && doActivate.IsDo)
        {
            SiDo = true;
            DoSi = true;
        }
    }

    public void Notes(string note)
    {

        if (TypedNotesS2[0] == "null")
        {
            TypedNotesS2[0] = note;
            NoteTyped += 1;
        }
        else if (TypedNotesS2[1] == "null")
        {
            TypedNotesS2[1] = note;
            NoteTyped += 1;
        }
        else if (TypedNotesS2[2] == "null")
        {
            TypedNotesS2[2] = note;
            NoteTyped += 1;
        }
        else if (TypedNotesS2[3] == "null")
        {
            TypedNotesS2[3] = note;
            NoteTyped += 1;
        }
        else if (TypedNotesS2[4] == "null")
        {
            TypedNotesS2[4] = note;
            Console.WriteLine(TypedNotesS2[4]);
            NoteTyped += 1;
        }
        else if (TypedNotesS2[5] == "null")
        {
            TypedNotesS2[5] = note;
            Console.WriteLine(TypedNotesS2[5]);
            NoteTyped += 1;
        }
        else if (TypedNotesS2[6] == "null")
        {
            TypedNotesS2[6] = note;
            Console.WriteLine(TypedNotesS2[6]);
            NoteTyped += 1;
        }
        else if (TypedNotesS2[7] == "null")
        {
            TypedNotesS2[7] = note;
            Console.WriteLine(TypedNotesS2[7]);
            NoteTyped += 1;
        }
        else if (TypedNotesS2[8] == null)
        {
            TypedNotesS2[8] = null;
            Console.WriteLine(TypedNotesS2[8]);
            NoteTyped += 1;
        }
        if (NoteTyped == 9)
        {
            string resTypesN = string.Concat(TypedNotesS2);
         
                if (resTypesN == GoodNotes2 || resTypesN == GoodNotes2_1 && MiSol || SolMi && FaRe || ReFa && ReLa || LaRe)
                {
                    Debug.Log("2222");
                }
                else
                {
                    NoteTyped = 0;
                    TypedNotesS2[0] = "null";
                    TypedNotesS2[1] = "null";
                    TypedNotesS2[2] = "null";
                    TypedNotesS2[3] = "null";
                    TypedNotesS2[4] = "null";
                    TypedNotesS2[5] = "null";
                    TypedNotesS2[6] = "null";
                    TypedNotesS2[7] = "null";
                    TypedNotesS2[8] = "null";
                }           
        }
    }
}
