using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;

public class RealTimeDatabase : MonoBehaviour
{
    List<List<string>> data = new List<List<string>>();

    int counter = 0;

    DatabaseReference reference;
    // Start is called before the first frame update
    void Start()
    {
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        ReadData("Questions_1");
        ReadData("Questions_2");
        ReadData("Questions_3");

        DebugData();
    }

    public void ReadData(string Questions){
        FirebaseDatabase.DefaultInstance
        .GetReference(Questions)
        .ValueChanged += (object sender, ValueChangedEventArgs e) => {
            if (e.DatabaseError != null) {
                Debug.LogError (e.DatabaseError.Message);
            }

            var q2_counter=-1;

            if (Questions=="Questions_2"){
                q2_counter=0;
            }

            if (e.Snapshot != null && e.Snapshot.ChildrenCount > 0) {

                foreach (var childSnapshot in e.Snapshot.Children) {
                    
                        data.Add(new List<string>());

                        data[counter].Add(counter.ToString());

                        if (Questions=="Questions_2" && q2_counter>=0){

                            if (childSnapshot.Child("index").Value.ToString()=="13" || childSnapshot.Child("index").Value.ToString()=="14"){

                                var Answer1 = childSnapshot.Child("Answer1").Value.ToString();
                                Debug.Log(Answer1); 
                                var Answer2 = childSnapshot.Child("Answer2").Value.ToString();
                                Debug.Log(Answer2); 
                                
                                data[counter].Add(Answer1);
                                data[counter].Add(Answer2);
                            }

                            q2_counter++;
                        }
                        else{

                            var Answer = childSnapshot.Child("Answer").Value.ToString(); 

                            data[counter].Add(Answer);
                        }

                        var Question = childSnapshot.Child("Question").Value.ToString();
                        var choice1 = childSnapshot.Child("choice1").Value.ToString();
                        var choice2 = childSnapshot.Child("choice2").Value.ToString();
                        var choice3 = childSnapshot.Child("choice3").Value.ToString();
                        var choice4 = childSnapshot.Child("choice4").Value.ToString();

                        data[counter].Add(Question);
                        data[counter].Add(choice1);
                        data[counter].Add(choice2);
                        data[counter].Add(choice3);
                        data[counter].Add(choice4);

                        counter++;
                    }
                }
        };
    }

    public void DebugData(){
        for (int i = 0; i<counter; i++){
                for (int j = 0; j<data[i].Count; j++){
                    Debug.Log(data[i][j]);
            }
        }
    }     
} 
