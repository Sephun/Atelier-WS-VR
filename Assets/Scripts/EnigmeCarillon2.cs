using System;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeCarillon2 : MonoBehaviour
{
    public AudioSource SuccessNoise;
    public AudioSource FailNoise;

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

    public bool MiSol;
    public bool SolMi;
    public bool LaRe;
    public bool ReLa;
    public bool FaRe;
    public bool ReFa;

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
        else if (TypedNotesS2[8] == "null")
        {
            TypedNotesS2[8] = note;
            Console.WriteLine(TypedNotesS2[8]);
            NoteTyped += 1;
        }
        if (NoteTyped == 9)
        {
            string resTypesN = string.Concat(TypedNotesS2);
         
            if (resTypesN == GoodNotes2 || resTypesN == GoodNotes2_1 && MiSol || SolMi && FaRe || ReFa && ReLa || LaRe)
            {
                SuccessNoise.Play();
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

                ReLa = false;
                LaRe = false;
                FaRe = false;
                ReFa = false;
                MiSol = false;
                SolMi = false;

                FailNoise.Play();
            }           
        }
    }
}
