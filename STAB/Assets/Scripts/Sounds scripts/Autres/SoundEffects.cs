using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public static SoundEffects Instance;

    // Initialisation des variables sons
    public AudioClip Punch_1;
    public AudioClip Face_punch_1;
    
    public AudioClip SH_Nlight;
    public AudioClip SH_Dlight;
    public AudioClip SH_Nair;
    public AudioClip SH_Sair;
    public AudioClip SH_Suicideatk;

    public AudioClip MET_Tombant;
    public AudioClip MET_Explosion;

    public AudioClip PC_Splash;
    public AudioClip PC_Couppied;
    public AudioClip PC_Jeté;
    public AudioClip PC_Sair;

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

    public void Make_SHNlight()
    {
        MakeSound(SH_Nlight);
    }
    
    public void Make_SHDlight()
    {
        MakeSound(SH_Dlight);
    }
    
    public void Make_SHNair()
    {
        MakeSound(SH_Nair);
    }
    
    public void Make_SHSair()
    {
        MakeSound(SH_Sair);
    }
    
    public void Make_SHSuicideatk()
    {
        MakeSound(SH_Suicideatk);
    }
    
    public void Make_METtombant()
    {
        MakeSound(MET_Tombant);
    }
    
    public void Make_METexplosion()
    {
        MakeSound(MET_Explosion);
    }
    
    public void Make_PCSplash()
    {
        MakeSound(PC_Splash);
    }
    
    public void Make_PCCouppied()
    {
        MakeSound(PC_Couppied);
    }
    
    public void Make_PCJeté()
    {
        MakeSound(PC_Jeté);
    }
    
    public void Make_PCSair()
    {
        MakeSound(PC_Sair);
    }

    
    // Lance la lecture d'un son
    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, new Vector3(0,0,0));
    }
    
    
    
}
