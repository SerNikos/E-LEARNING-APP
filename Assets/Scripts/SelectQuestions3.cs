using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=System.Random;

public class SelectQuestions3 : MonoBehaviour
{
    private List<List<string>> data;

    // Start is called before the first frame update
    void Start()
    {
        data = RealTimeDatabase.Questions_3;

        //QuestionSelectorTrueFalse();
        //QuestionSelectorMultipleChoice();
    }

    public void QuestionSelectorTrueFalse(){
        Random random = new Random();

        string firstQ = random.Next(0,6).ToString();

        string secondQ = random.Next(0,6).ToString();

        while (secondQ == firstQ){
            secondQ = random.Next(0,6).ToString();
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

        string firstQ = random.Next(6,12).ToString();

        string secondQ = random.Next(6,12).ToString();

        while (secondQ == firstQ){
            secondQ = random.Next(6,12).ToString();
        }

        string thirdQ = random.Next(6,12).ToString();

        while (thirdQ == firstQ || thirdQ == secondQ){
            thirdQ = random.Next(6,12).ToString();
        }

        for (int i = 0; i<data.Count; i++){
            if (data[i][0] == firstQ || data[i][0] == secondQ || data[i][0] == thirdQ){
                //function to replace text on test
                Debug.Log(data[i][0]);
            }
        }
    }
}