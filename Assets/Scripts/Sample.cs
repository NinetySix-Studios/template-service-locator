using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
   private SampleGameManager _sampleGameManager => SampleGameManager.Services;
   private AudioManager _audioManager => AudioManager.Services;

   private NameCollection _nameCollection => NameCollection.Services;
   private void Start()
   {
      _sampleGameManager.OnStartShowMessage();
      PlayAudio();
      DisplayName();
   }

   private void PlayAudio()
   {
      Debug.Log($"Audio Played!!");
      _audioManager.PlayOneShot(_audioManager.TestAudio);
   }

   private void DisplayName()
   {
      string randomNames = _nameCollection.GetRandomNames();
      Debug.Log($"Name: {randomNames}");
   }
}
