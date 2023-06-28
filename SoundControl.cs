using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioClip[] aClips;
    public AudioClip instrumentName;
    public AudioSource myAudioSource;
    string instName;

    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                instName = Hit.transform.name;
                switch (instName)
                {
                    case "Violin_01":
                        myAudioSource.clip = aClips[0];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "SingleDrum_01":
                        myAudioSource.clip = aClips[1];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Trumpet_01":
                        myAudioSource.clip = aClips[2];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Tuba_01":
                        myAudioSource.clip = aClips[3];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Saxophone_01":
                        myAudioSource.clip = aClips[4];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Synthesizer_01":
                        myAudioSource.clip = aClips[5];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Harmonica_01":
                        myAudioSource.clip = aClips[6];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Clarinet_01":
                        myAudioSource.clip = aClips[7];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Gong_01":
                        myAudioSource.clip = aClips[8];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Cymbals":
                        myAudioSource.clip = aClips[9];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "CongaDrum_02":
                        myAudioSource.clip = aClips[10];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Tambourine_01":
                        myAudioSource.clip = aClips[11];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Piano_01":
                        myAudioSource.clip = aClips[12];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Lute_01":
                        myAudioSource.clip = aClips[13];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Chello_01":
                        myAudioSource.clip = aClips[14];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Banjo_01":
                        myAudioSource.clip = aClips[15];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "ElectricGuitar_01":
                        myAudioSource.clip = aClips[16];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Ukulele_01":
                        myAudioSource.clip = aClips[17];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "Harp_01":
                        myAudioSource.clip = aClips[18];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                    case "AcousticGuitar_02":
                        myAudioSource.clip = aClips[19];
                        myAudioSource.volume = 0.1f;
                        myAudioSource.Play();
                        break;
                }
            }
        }
    }

    public void PlayNameAudio()
    {
        myAudioSource.clip = instrumentName;
        myAudioSource.volume = 1;
        myAudioSource.Play();
    }

    public void StopNameAudio()
    {
        myAudioSource.clip = instrumentName;
        myAudioSource.Stop();
    }

    public void StopInstrumentSound(GameObject instrument)
    {
        switch (instrument.tag)
        {
            case "Violin":
                myAudioSource.clip = aClips[0];
                myAudioSource.Stop();
                break;
            case "Drum":
                myAudioSource.clip = aClips[1];
                myAudioSource.Stop();
                break;
            case "Trumpet":
                myAudioSource.clip = aClips[2];
                myAudioSource.Stop();
                break;
            case "Tuba":
                myAudioSource.clip = aClips[3];
                myAudioSource.Stop();
                break;
            case "Saxophone":
                myAudioSource.clip = aClips[4];
                myAudioSource.Stop();
                break;
            case "Synthesizer":
                myAudioSource.clip = aClips[5];
                myAudioSource.Stop();
                break;
            case "Harmonica":
                myAudioSource.clip = aClips[6];
                myAudioSource.Stop();
                break;
            case "Clarinet":
                myAudioSource.clip = aClips[7];
                myAudioSource.Stop();
                break;
            case "Gong":
                myAudioSource.clip = aClips[8];
                myAudioSource.Stop();
                break;
            case "Cymbals":
                myAudioSource.clip = aClips[9];
                myAudioSource.Stop();
                break;
            case "Conga":
                myAudioSource.clip = aClips[10];
                myAudioSource.Stop();
                break;
            case "Tambourine":
                myAudioSource.clip = aClips[11];
                myAudioSource.Stop();
                break;
            case "Piano":
                myAudioSource.clip = aClips[12];
                myAudioSource.Stop();
                break;
            case "Lute":
                myAudioSource.clip = aClips[13];
                myAudioSource.Stop();
                break;
            case "Cello":
                myAudioSource.clip = aClips[14];
                myAudioSource.Stop();
                break;
            case "Banjo":
                myAudioSource.clip = aClips[15];
                myAudioSource.Stop();
                break;
            case "Electric Guitar":
                myAudioSource.clip = aClips[16];
                myAudioSource.Stop();
                break;
            case "Ukulele":
                myAudioSource.clip = aClips[17];
                myAudioSource.Stop();
                break;
            case "Harp":
                myAudioSource.clip = aClips[18];
                myAudioSource.Stop();
                break;
            case "Acoustic Guitar":
                myAudioSource.clip = aClips[19];
                myAudioSource.Stop();
                break;
        }

        //myAudioSource.clip = aClips[0];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[1];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[2];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[3];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[4];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[5];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[6];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[7];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[8];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[9];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[10];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[11];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[12];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[13];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[14];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[15];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[16];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[17];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[18];
        //myAudioSource.Stop();

        //myAudioSource.clip = aClips[19];
        //myAudioSource.Stop();
    }
}
