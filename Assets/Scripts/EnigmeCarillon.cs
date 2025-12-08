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
 
    public GameObject Statuette1;

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

    public List<string> TypedNotesS1 = new List<string>(7);
    public int NoteTyped = 0;

    public bool statuette1;
    public bool statuette2;
    public bool statuette3;

    public string GoodNotes1 = "FaLaMiSiDoMiReSi";
    public string GoodNotes1_1 = "FaLaMiSiMiDoSiRe";

    public void Awake()
    {
        TypedNotesS1[0] = "null";
        TypedNotesS1[1] = "null";
        TypedNotesS1[2] = "null";
        TypedNotesS1[3] = "null";
        TypedNotesS1[4] = "null";
        TypedNotesS1[5] = "null";
        TypedNotesS1[6] = "null";
        TypedNotesS1[7] = "null";
        statuette1 = true;
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
        
        if (TypedNotesS1[0] == "null")
        {
            TypedNotesS1[0] = note;
            Console.WriteLine(TypedNotesS1[0]);
            NoteTyped += 1;
        }
        else if(TypedNotesS1[1] == "null")
        {
            TypedNotesS1[1] = note;
            Console.WriteLine(TypedNotesS1[1]);
            NoteTyped += 1;
        }
        else if (TypedNotesS1[2] == "null")
        {
            TypedNotesS1[2] = note;
            Console.WriteLine(TypedNotesS1[2]);
            NoteTyped += 1;
        }
        else if (TypedNotesS1[3] == "null")
        {
            TypedNotesS1[3] = note;
            Console.WriteLine(TypedNotesS1[3]);
            NoteTyped += 1;
        }
        else if (TypedNotesS1[4] == "null")
        {
            TypedNotesS1[4] = note;
            Console.WriteLine(TypedNotesS1[4]);
            NoteTyped += 1;
        }
        else if (TypedNotesS1[5] == "null")
        {
            TypedNotesS1[5] = note;
            Console.WriteLine(TypedNotesS1[5]);
            NoteTyped += 1;
        }
        else if (TypedNotesS1[6] == "null")
        {
            TypedNotesS1[6] = note;
            Console.WriteLine(TypedNotesS1[6]);
            NoteTyped += 1;
        }
        else if (TypedNotesS1[7] == "null")
        {
            TypedNotesS1[7] = note;
            Console.WriteLine(TypedNotesS1[7]);
            NoteTyped += 1;
        }

        if (NoteTyped == 8)
        {
            string resTypesN = string.Concat(TypedNotesS1);

            if (statuette1)
            {
                if (resTypesN == GoodNotes1 || resTypesN == GoodNotes1_1 && DoMi || MiDo && ReSi || SiRe)
                {
                    Console.WriteLine("1111111111");
                    statuette1 = true;
                }
                else
                {
                    NoteTyped = 0;
                    TypedNotesS1[0] = "null";
                    TypedNotesS1[1] = "null";
                    TypedNotesS1[2] = "null";
                    TypedNotesS1[3] = "null";
                    TypedNotesS1[4] = "null";
                    TypedNotesS1[5] = "null";
                    TypedNotesS1[6] = "null";
                    TypedNotesS1[7] = "null";
                }
            }
        }

        
    }
}
