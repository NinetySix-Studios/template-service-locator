using System.Collections;
using System.Collections.Generic;
using Project.Services;
using UnityEngine;

namespace Project.Managers
{
    public class SampleManager : MonoBehaviour
    {
        public static SampleManager Services { get { if (_sampleManager == null) _sampleManager = Game.Services.Get<SampleManager>(); return _sampleManager; } }
        private static SampleManager _sampleManager;
        
        /// <summary>
        /// Used for testing purposes
        /// This method calls a debug log
        /// </summary>
        public void SampleMethod()
        {
            Debug.Log("Sample Manager : Game Bindings is Working!");
        }
    }
}