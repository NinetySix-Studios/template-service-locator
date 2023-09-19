using System.Collections;
using System.Collections.Generic;
using Project.Services;
using UnityEngine;

public class SampleGameManager : MonoBehaviour
{
    public static SampleGameManager Services
    {
        get
        {
            if (_ == null) _ = Game.Services.Get<SampleGameManager>();
            return _;
        }
    }
    private static SampleGameManager _;

    public void OnStartShowMessage()
    {
        Debug.Log($"Hello everyone! Hello everyone! Hello everyone!");
    }
}
