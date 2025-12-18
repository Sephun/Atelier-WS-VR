using System;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class EnigmeCarillon3 : MonoBehaviour
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

    public bool SiDo;
    public bool DoSi;
    public bool SolRe;
    public bool ReSol;
    public bool MiSi;
    public bool SiMi;
    public bool ReSi;
    public bool SiRe;

    public bool isFinished3;

    public List<string> TypedNotesS3 = new List<string>(10);
    public int NoteTyped = 0;

    public string GoodNotes3 = "ReSiMiSiFaSolReLaSiDo";
    public string GoodNotes3_1 = "SiReSiMiFaReSolLaDoSi";

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
    }

    public void Update()
    {
        if (reActivate.IsRe && siActivator.IsSi)
        {
            ReSi = true;
            SiRe = true;
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
        else if (TypedNotesS3[8] == "null")
        {
            TypedNotesS3[8] = note;
            Console.WriteLine(TypedNotesS3[8]);
            NoteTyped += 1;
        }
        else if (TypedNotesS3[9] == "null")
        {
            TypedNotesS3[9] = note;
            Console.WriteLine(TypedNotesS3[9]);
            NoteTyped += 1;
        }
        if (NoteTyped == 10)
        {
            string resTypesN = string.Concat(TypedNotesS3);

            if (resTypesN == GoodNotes3 || resTypesN == GoodNotes3_1 && ReSi || SiRe && MiSi || SiMi && SolRe || ReSol && SiDo || DoSi)
            {
                SuccessNoise.Play();
                isFinished3 = true;

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

                SiDo = false;
                DoSi = false;
                SolRe = false;
                ReSol = false;
                MiSi = false;
                SiMi = false;
                ReSi = false;
                SiRe = false;

                FailNoise.Play();
            }
        }
    }
}
