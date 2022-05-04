using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=System.Random;
using TMPro;
using System;

public class SelectQuestions1 : MonoBehaviour
{
    private List<List<string>> data;

    [SerializeField]
    private TMP_Text Question1,Question2,Question3,Question4,Question5; 

    void Awake() {
        Question1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question1").GetComponent<TMP_Text>();
        Question2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question2").GetComponent<TMP_Text>();
        Question3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3").GetComponent<TMP_Text>();
        Question4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4").GetComponent<TMP_Text>();
        Question5 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5").GetComponent<TMP_Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        data = RealTimeDatabase.Questions_1;

        QuestionSelectorTrueFalse();
        QuestionSelectorMultipleChoice();
    }

    public void QuestionSelectorTrueFalse(){
        Random random = new Random();

        string firstQ = random.Next(0,6).ToString();

        string secondQ = random.Next(0,6).ToString();

        while (secondQ == firstQ){
            secondQ = random.Next(0,6).ToString();
        }

        for (int i = 0; i<data.Count; i++){
            if (data[i][0] == firstQ){
                //function to replace text on test
                Question1.text = data[i][2];
            }
            else if (data[i][0] == secondQ) {
                Question2.text = data[i][2];
            }
        }
    }

    public void QuestionSelectorMultipleChoice(){
        Random random = new Random();

        string firstQ = random.Next(6,13).ToString();

        string secondQ = random.Next(6,13).ToString();

        while (secondQ == firstQ){
            secondQ = random.Next(6,13).ToString();
        }

        string thirdQ = random.Next(6,13).ToString();

        while (thirdQ == firstQ || thirdQ == secondQ){
            thirdQ = random.Next(6,13).ToString();
        }

        for (int i = 0; i<data.Count; i++){
            if (data[i][0] == firstQ ){
                //function to replace text on test
                Question3.text = data[i][2];
            }
            else if (data[i][0] == secondQ){
                Question4.text = data[i][2];
            }
            else if (data[i][0] == thirdQ) {
                Question5.text = data[i][2];
            }
        }
    }
}