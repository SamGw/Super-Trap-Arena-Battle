using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public static SoundEffects Instance;

    // Initialisation des variables sons
    public AudioClip Punch_1;
    public AudioClip Face_punch_1;

    void Awake()
    {
        Instance = this;
    }

    public void Make_KickSound()
    {
        MakeSound(Punch_1);
    }

    public void Make_FaceSound()
    {
        MakeSound(Face_punch_1);
    }

    
    // Lance la lecture d'un son
    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, new Vector3(0,0,0));
    }
    
    
    
}
