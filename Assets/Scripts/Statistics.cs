using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;
using Firebase.Auth;
using TMPro;

public class Statistics : MonoBehaviour
{
    DatabaseReference reference;

    public FirebaseAuth auth;  

    [SerializeField]
    private TMP_Text Score1,Score2,Score3,ScoreAll;

    // Start is called before the first frame update
    void Start()
    {
        auth = FirebaseAuth.DefaultInstance;
        string user = auth.CurrentUser.UserId.ToString();

        reference = FirebaseDatabase.DefaultInstance.RootReference;

        ReadStatistics(user);
    }

    public void ReadStatistics (string user) {
         FirebaseDatabase.DefaultInstance
      .GetReference("Users").Child(user)
      .GetValueAsync().ContinueWithOnMainThread(task => {
        if (task.IsFaulted) {
            // Handle the error...
            DataSnapshot snapshot = task.Result;
            Debug.Log(task.Result);
        }
        else if (task.IsCompleted) {
          DataSnapshot snapshot = task.Result;
            // Do something with snapshot...

            Score1 = GameObject.Find("Canvas/Panel/Score_1").GetComponent<TMP_Text>();
            Score1.text = snapshot.Child("score_1").Value.ToString()+"/100";

            Score2 = GameObject.Find("Canvas/Panel/Score_2").GetComponent<TMP_Text>();
            Score2.text = snapshot.Child("score_2").Value.ToString()+"/100";

            Score3 = GameObject.Find("Canvas/Panel/Score_3").GetComponent<TMP_Text>();
            Score3.text = snapshot.Child("score_3").Value.ToString()+"/100";

            ScoreAll = GameObject.Find("Canvas/Panel/Score_all").GetComponent<TMP_Text>();
            ScoreAll.text = snapshot.Child("score_all").Value.ToString()+"/100";
        }
      });
    }
}
