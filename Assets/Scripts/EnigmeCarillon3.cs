using System;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class EnigmeCarillon3 : MonoBehaviour
{
    public GameObject Do;
    public GameObject Re;
    public GameObject Mi;
    public GameObject Fa;
    public GameObject Sol;
    public GameObject La;
    public GameObject Si;

    public GameObject Statuette1;
    public GameObject Statuette2;
    public GameObject Statuette3;

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

    public List<string> TypedNotesS3 = new List<string>(9);
    public int NoteTyped = 0;

    public bool statuette1;
    public bool statuette2;
    public bool statuette3;

    public string GoodNotes3 = "MiSolFaReReLaLaSolDo";
    public string GoodNotes3_1 = "SolMiReFaLaReLaSolDo";

    public void Awake()
    {
        TypedNotesS3[0] = "null";
        TypedNotesS3[1] = "null";
        TypedNotesS3[2] = "null";
        TypedNotesS3[3] = "null";
        TypedNotesS3[4] = "null";
        TypedNotesS3[5] = "null";
        TypedNotesS3[6] = "null";
        TypedNotesS3[7] = "null";
        TypedNotesS3[8] = "null";
        TypedNotesS3[9] = "null";
        statuette3 = true;
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

        if (TypedNotesS3[0] == "null")
        {
            TypedNotesS3[0] = note;
            Console.WriteLine(TypedNotesS3[0]);
            NoteTyped += 1;
        }
        else if (TypedNotesS3[1] == "null")
        {
            TypedNotesS3[1] = note;
            Console.WriteLine(TypedNotesS3[1]);
            NoteTyped += 1;
        }
        else if (TypedNotesS3[2] == "null")
        {
            TypedNotesS3[2] = note;
            Console.WriteLine(TypedNotesS3[2]);
            NoteTyped += 1;
        }
        else if (TypedNotesS3[3] == "null")
        {
            TypedNotesS3[3] = note;
            Console.WriteLine(TypedNotesS3[3]);
            NoteTyped += 1;
        }
        else if (TypedNotesS3[4] == "null")
        {
            TypedNotesS3[4] = note;
            Console.WriteLine(TypedNotesS3[4]);
            NoteTyped += 1;
        }
        else if (TypedNotesS3[5] == "null")
        {
            TypedNotesS3[5] = note;
            Console.WriteLine(TypedNotesS3[5]);
            NoteTyped += 1;
        }
        else if (TypedNotesS3[6] == "null")
        {
            TypedNotesS3[6] = note;
            Console.WriteLine(TypedNotesS3[6]);
            NoteTyped += 1;
        }
        else if (TypedNotesS3[7] == "null")
        {
            TypedNotesS3[7] = note;
            Console.WriteLine(TypedNotesS3[7]);
            NoteTyped += 1;
        }
        else if (TypedNotesS3[8] == null)
        {
            TypedNotesS3[8] = null;
            Console.WriteLine(TypedNotesS3[8]);
            NoteTyped += 1;
        }
        else if (TypedNotesS3 == null)
        {
            TypedNotesS3[9] = null;
            Console.WriteLine(TypedNotesS3[9]);
            NoteTyped -= 1;
        }
        if (NoteTyped == 9)
        {
            string resTypesN = string.Concat(TypedNotesS3);

            if (statuette3)
            {
                if (resTypesN == GoodNotes3 || resTypesN == GoodNotes3_1 && ReSi || SiRe && MiSi || SiMi && SolRe || ReSol && SiDo || DoSi)
                {
                    Console.WriteLine("1111111111");
                    statuette3 = true;
                }
                else
                {
                    NoteTyped = 0;
                    TypedNotesS3[0] = "null";
                    TypedNotesS3[1] = "null";
                    TypedNotesS3[2] = "null";
                    TypedNotesS3[3] = "null";
                    TypedNotesS3[4] = "null";
                    TypedNotesS3[5] = "null";
                    TypedNotesS3[6] = "null";
                    TypedNotesS3[7] = "null";
                    TypedNotesS3[8] = "null";
                    TypedNotesS3[9] = "null";
                }
            }
        }


    }
}
