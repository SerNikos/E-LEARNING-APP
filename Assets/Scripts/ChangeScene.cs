using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ChangeScene : MonoBehaviour
{
  public static string PreviousLevel {get; private set;}

  public void LoadScene(string sceneName)
   {
       SceneManager.LoadScene(sceneName);
   }

   private void OnDestroy()
     {
         PreviousLevel = gameObject.scene.name;
     }
}