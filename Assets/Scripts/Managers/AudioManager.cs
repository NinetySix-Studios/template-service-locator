using System.Collections;
using System.Collections.Generic;
using Project.Services;
using UnityEngine;
using UnityEngine.Serialization;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Services
    {
        get
        {
            if (_ == null) _ = Game.Services.Get<AudioManager>();
            return _;
        }
    }
    private static AudioManager _;

    
    [SerializeField]
    private AudioSource _audioSource;

    [field: SerializeField] public AudioClip TestAudio { get; set; }

    public void PlayOneShot(AudioClip clip)
    {
        _audioSource.PlayOneShot(clip);
    }

}
