using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=System.Random;

public class SelectQuestionsFinal : MonoBehaviour
{
    private List<List<string>> data1;
    private List<List<string>> data2;
    private List<List<string>> data3;

    // Start is called before the first frame update
    void Start()
    {
        data1 = RealTimeDatabase.Questions_1;
        data2 = RealTimeDatabase.Questions_2;
        data3 = RealTimeDatabase.Questions_3;

        QuestionSelectorTrueFalse();
        QuestionSelectorMultipleChoice();
        QuestionSelectorMultipleChoice2Answers();
    }

    public void QuestionSelectorTrueFalse(){
        Random random = new Random();

        string firstQ = random.Next(0,6).ToString();

        string secondQ = random.Next(0,8).ToString();

        string thirdQ = random.Next(0,6).ToString();

        for (int i = 0; i<data1.Count; i++){
            if (data1[i][0] == firstQ){
                //function to replace text on test
                Debug.Log(data1[i][0]);
                Debug.Log(data1[i][1]);
            }
        }

        for (int i = 0; i<data2.Count; i++){
            if (data2[i][0] == secondQ){
                //function to replace text on test
                Debug.Log(data2[i][0]);
                Debug.Log(data2[i][1]);
            }
        }

        for (int i = 0; i<data3.Count; i++){
            if (data3[i][0] == thirdQ){
                //function to replace text on test
                Debug.Log(data3[i][0]);
                Debug.Log(data3[i][1]);
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

        string thirdQ = random.Next(8,13).ToString();

        string fourthQ = random.Next(8,13).ToString();

        while (fourthQ == thirdQ){
            fourthQ = random.Next(8,13).ToString();
        }

        string fifthQ = random.Next(6,12).ToString();

        string sixthQ = random.Next(6,12).ToString();

        while (sixthQ == fifthQ){
            sixthQ = random.Next(6,12).ToString();
        }

        for (int i = 0; i<data1.Count; i++){
            if (data1[i][0] == firstQ || data1[i][0] == secondQ){
                //function to replace text on test
                Debug.Log(data1[i][0]);
                Debug.Log(data1[i][1]);
            }
        }

        for (int i = 0; i<data2.Count; i++){
            if (data2[i][0] == thirdQ || data2[i][0] == fourthQ){
                //function to replace text on test
                Debug.Log(data2[i][0]);
                Debug.Log(data2[i][1]);
            }
        }
    
        for (int i = 0; i<data3.Count; i++){
            if (data3[i][0] == fifthQ || data3[i][0] == sixthQ){
                //function to replace text on test
                Debug.Log(data3[i][0]);
                Debug.Log(data3[i][1]);
            }
        }
    }

    public void QuestionSelectorMultipleChoice2Answers(){
        Random random = new Random();

        string firstQ = random.Next(13,15).ToString();

        for (int i = 0; i<data2.Count; i++){
            if (data2[i][0] == firstQ){
                //function to replace text on test
                Debug.Log(data2[i][0]);
                Debug.Log(data2[i][1]);
                Debug.Log(data2[i][2]);
            }
        }
    }
}