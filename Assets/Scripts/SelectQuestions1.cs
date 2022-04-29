using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=System.Random;

public class SelectQuestions1 : MonoBehaviour
{
    private List<List<string>> data;

    // Start is called before the first frame update
    void Start()
    {
        data = RealTimeDatabase.Questions_1;

        QuestionSelector();
    }

    public void QuestionSelector(){
        Random random = new Random();

        string firstQ = random.Next(0,6).ToString();

        string secondQ = random.Next(0,6).ToString();

        while (secondQ == firstQ){
            secondQ = random.Next(0,6).ToString();
        }

        //Debug.Log(firstQ + secondQ);
    }
}