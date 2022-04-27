using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;

public class RealTimeDatabase : MonoBehaviour
{
    DatabaseReference reference;
    // Start is called before the first frame update
    void Start()
    {
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        ReadData();
    }

    public void ReadData(){
        FirebaseDatabase.DefaultInstance
        .GetReference("Questions_1")
        .ValueChanged += (object sender, ValueChangedEventArgs e) => {
            if (e.DatabaseError != null) {
                Debug.LogError (e.DatabaseError.Message);
            }


            if (e.Snapshot != null && e.Snapshot.ChildrenCount > 0) {

                int counter = 0;

                foreach (var childSnapshot in e.Snapshot.Children) {
                        var Answer = childSnapshot.Child("Answer").Value.ToString(); 
                        var Question = childSnapshot.Child("Question").Value.ToString(); 

                        counter++;

                        //text.text = name.ToString();
                        Debug.Log("Question = "+counter+" "+Question);                        
                        Debug.Log("Answer = "+Answer);
                        //text.text = childSnapshot.ToString();
                        
                    }
                }
        };
    }
} 
