using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;

public class RealTimeDatabase : MonoBehaviour
{
    DatabaseReference reference;

    public static List<List<string>> Questions_1 = new List<List<string>>();
    public static List<List<string>> Questions_2 = new List<List<string>>();
    public static List<List<string>> Questions_3 = new List<List<string>>();

    /*public static RealTimeDatabase Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null) 
        {
            Instance = this; 
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }

    }*/

    // Start is called before the first frame update
    void Start()
    {
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        
        ReadData("Questions_1");
        ReadData("Questions_2");
        ReadData("Questions_3");
    }

    public void ReadData(string Questions){
        FirebaseDatabase.DefaultInstance
        .GetReference(Questions)
        .ValueChanged += (object sender, ValueChangedEventArgs e) => {
            
            List<List<string>> data = new List<List<string>>();

            if (e.DatabaseError != null) {
                Debug.LogError (e.DatabaseError.Message);
            }

            var q2_counter=-1;

            if (Questions=="Questions_2"){
                q2_counter=0;
            }

            if (e.Snapshot != null && e.Snapshot.ChildrenCount > 0) {

                foreach (var childSnapshot in e.Snapshot.Children) {

                    var counter = data.Count;
                    
                    data.Add(new List<string>());

                    var index = childSnapshot.Child("index").Value.ToString();

                    data[counter].Add(index);

                    if (Questions=="Questions_2" && q2_counter>=0){

                        if (childSnapshot.Child("index").Value.ToString()=="13" || childSnapshot.Child("index").Value.ToString()=="14"){

                            var Answer1 = childSnapshot.Child("Answer1").Value.ToString();
                            var Answer2 = childSnapshot.Child("Answer2").Value.ToString();
                            
                            data[counter].Add(Answer1);
                            data[counter].Add(Answer2);
                        }
                        else{

                            var Answer = childSnapshot.Child("Answer").Value.ToString(); 

                            data[counter].Add(Answer);
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
                }
                if (Questions == "Questions_1"){
                    AddQuestions1(data);
                }
                else if (Questions == "Questions_2"){
                    AddQuestions2(data);
                }
                else if (Questions == "Questions_3"){
                    AddQuestions3(data);
                }
            }
        };
    }

    public void AddQuestions1(List<List<string>> data){
        for (int i = 0; i<data.Count; i++){
            Questions_1.Add(new List<string>());
            for (int j = 0; j<data[i].Count; j++){
                Questions_1[i].Add(data[i][j]);
            }
        }
    }

    public void AddQuestions2(List<List<string>> data){
        for (int i = 0; i<data.Count; i++){
            Questions_2.Add(new List<string>());
            for (int j = 0; j<data[i].Count; j++){
                Questions_2[i].Add(data[i][j]);
            }
        }
    }

    public void AddQuestions3(List<List<string>> data){
        for (int i = 0; i<data.Count; i++){
            Questions_3.Add(new List<string>());
            for (int j = 0; j<data[i].Count; j++){
                Questions_3[i].Add(data[i][j]);
            }
        }
    }
} 
