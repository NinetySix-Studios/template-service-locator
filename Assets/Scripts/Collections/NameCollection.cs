using System.Collections;
using System.Collections.Generic;
using Project.Services;
using UnityEngine;

[CreateAssetMenu(fileName = "nameCollection")]
public class NameCollection : ScriptableObject
{
   public static NameCollection Services
   {
      get
      {
         if (_ == null) _ = Game.Services.Get<NameCollection>();
         return _;
      }
   }
   private static NameCollection _;

   [SerializeField]
   private List<string> _nameList = new();

   public string GetRandomNames()
   {
      return _nameList[Random.Range(0, _nameList.Count)];
   }

}
