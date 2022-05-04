using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=System.Random;

public class SelectQuestions2 : MonoBehaviour
{
    private List<List<string>> data;

    // Start is called before the first frame update
    void Start()
    {
        data = RealTimeDatabase.Questions_2;

        //QuestionSelectorTrueFalse();
        //QuestionSelectorMultipleChoice();
    }

    public void QuestionSelectorTrueFalse(){
        Random random = new Random();

        string firstQ = random.Next(0,8).ToString();

        string secondQ = random.Next(0,8).ToString();

        while (secondQ == firstQ){
            secondQ = random.Next(0,8).ToString();
        }

        for (int i = 0; i<data.Count; i++){
            if (data[i][0] == firstQ || data[i][0] == secondQ){
                //function to replace text on test
                //Debug.Log(data[i][0]);
            }
        }
    }

    public void QuestionSelectorMultipleChoice(){
        Random random = new Random();

        string firstQ = random.Next(8,13).ToString();

        string secondQ = random.Next(8,13).ToString();

        while (secondQ == firstQ){
            secondQ = random.Next(8,13).ToString();
        }

        for (int i = 0; i<data.Count; i++){
            if (data[i][0] == firstQ || data[i][0] == secondQ){
                //function to replace text on test
                Debug.Log(data[i][0]);
            }
        }
    }

    public void QuestionSelectorMultipleChoice2Answers(){
        Random random = new Random();

        string firstQ = random.Next(13,15).ToString();

        for (int i = 0; i<data.Count; i++){
            if (data[i][0] == firstQ){
                //function to replace text on test
                Debug.Log(data[i][0]);
                Debug.Log(data[i][1]);
                Debug.Log(data[i][2]);
            }
        }
    }
}