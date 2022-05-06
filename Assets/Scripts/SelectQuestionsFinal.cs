using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=System.Random;
using TMPro;
using System;

public class SelectQuestionsFinal : MonoBehaviour
{
    private List<List<string>> data1;
    private List<List<string>> data2;
    private List<List<string>> data3;

    [SerializeField]
    private TMP_Text Question1,Question2,Question3,Question4,Question5,Question6,Question7,Question8,Question9,Question10,
    choice4_1,choice4_2,choice4_3,choice4_4,choice5_1,choice5_2,choice5_3,choice5_4,choice6_1,choice6_2,choice6_3,choice6_4,
    choice7_1,choice7_2,choice7_3,choice7_4,choice8_1,choice8_2,choice8_3,choice8_4,choice9_1,choice9_2,choice9_3,choice9_4,
    choice10_1,choice10_2,choice10_3,choice10_4;

    public static String Answer1,Answer2,Answer3,Answer4,Answer5,Answer6,Answer7,Answer8,Answer9,Answer10_1,Answer10_2;

    void Awake() {  
        Question1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question1").GetComponent<TMP_Text>();
        Question2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question2").GetComponent<TMP_Text>();
        Question3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3").GetComponent<TMP_Text>();
        Question4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4").GetComponent<TMP_Text>();
        Question5 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5").GetComponent<TMP_Text>();
        Question6 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6").GetComponent<TMP_Text>();
        Question7 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7").GetComponent<TMP_Text>();
        Question8 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8").GetComponent<TMP_Text>();
        Question9 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9").GetComponent<TMP_Text>();
        Question10 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10").GetComponent<TMP_Text>();

        choice4_1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle1/Answer1").GetComponent<TMP_Text>();
        choice4_2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle2/Answer2").GetComponent<TMP_Text>();
        choice4_3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle3/Answer3").GetComponent<TMP_Text>();
        choice4_4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle4/Answer4").GetComponent<TMP_Text>();

        choice5_1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle1/Answer1").GetComponent<TMP_Text>();
        choice5_2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle2/Answer2").GetComponent<TMP_Text>();
        choice5_3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle3/Answer3").GetComponent<TMP_Text>();
        choice5_4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle4/Answer4").GetComponent<TMP_Text>();

        choice6_1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6/ToggleGroup6/Toggle1/Answer1").GetComponent<TMP_Text>();
        choice6_2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6/ToggleGroup6/Toggle2/Answer2").GetComponent<TMP_Text>();
        choice6_3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6/ToggleGroup6/Toggle3/Answer3").GetComponent<TMP_Text>();
        choice6_4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6/ToggleGroup6/Toggle4/Answer4").GetComponent<TMP_Text>();

        choice7_1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle1/Answer1").GetComponent<TMP_Text>();
        choice7_2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle2/Answer2").GetComponent<TMP_Text>();
        choice7_3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle3/Answer3").GetComponent<TMP_Text>();
        choice7_4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle4/Answer4").GetComponent<TMP_Text>();

        choice8_1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup8/Toggle1/Answer1").GetComponent<TMP_Text>();
        choice8_2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup8/Toggle2/Answer2").GetComponent<TMP_Text>();
        choice8_3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup8/Toggle3/Answer3").GetComponent<TMP_Text>();
        choice8_4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup8/Toggle4/Answer4").GetComponent<TMP_Text>();

        choice9_1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle1/Answer1").GetComponent<TMP_Text>();
        choice9_2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle2/Answer2").GetComponent<TMP_Text>();
        choice9_3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle3/Answer3").GetComponent<TMP_Text>();
        choice9_4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle4/Answer4").GetComponent<TMP_Text>();

        choice10_1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle1/Answer1").GetComponent<TMP_Text>();
        choice10_2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle2/Answer2").GetComponent<TMP_Text>();
        choice10_3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle3/Answer3").GetComponent<TMP_Text>();
        choice10_4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle4/Answer4").GetComponent<TMP_Text>();

    }

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
                Question1.text = data1[i][2];
                Answer1 = data1[i][1];
            }
        }

        for (int i = 0; i<data2.Count; i++){
            if (data2[i][0] == secondQ){
                //function to replace text on test
                Question2.text = data2[i][2];
                Answer2 = data2[i][1];
            }
        }

        for (int i = 0; i<data3.Count; i++){
            if (data3[i][0] == thirdQ){
                //function to replace text on test
                Question3.text = data3[i][2];
                Answer3 = data3[i][1];
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
            if (data1[i][0] == firstQ){
                //function to replace text on test
                Question4.text = data1[i][2];
                choice4_1.text = data1[i][3];
                choice4_2.text = data1[i][4];
                choice4_3.text = data1[i][5];
                choice4_4.text = data1[i][6];
                Answer4 = data1[i][1];
            }
            else if (data1[i][0] == secondQ) {
                Question5.text = data1[i][2];
                choice5_1.text = data1[i][3];
                choice5_2.text = data1[i][4];
                choice5_3.text = data1[i][5];
                choice5_4.text = data1[i][6];
                Answer5 = data1[i][1];
            }
        }

        for (int i = 0; i<data2.Count; i++){
            if (data2[i][0] == thirdQ){
                //function to replace text on test
                Question6.text = data2[i][2];
                choice6_1.text = data2[i][3];
                choice6_2.text = data2[i][4];
                choice6_3.text = data2[i][5];
                choice6_4.text = data2[i][6];
                Answer6 = data2[i][1];
            }
            else if (data2[i][0] == fourthQ) {
                Question7.text = data2[i][2];
                choice7_1.text = data2[i][3];
                choice7_2.text = data2[i][4];
                choice7_3.text = data2[i][5];
                choice7_4.text = data2[i][6];
                Answer7 = data2[i][1];
            }
        }
    
        for (int i = 0; i<data3.Count; i++){
            if (data3[i][0] == fifthQ){
                //function to replace text on test
                Question8.text = data3[i][2];
                choice8_1.text = data3[i][3];
                choice8_2.text = data3[i][4];
                choice8_3.text = data3[i][5];
                choice8_4.text = data3[i][6];
                Answer8 = data3[i][1];
            }
            else if (data3[i][0] == sixthQ) {
                Question9.text = data3[i][2];
                choice9_1.text = data3[i][3];
                choice9_2.text = data3[i][4];
                choice9_3.text = data3[i][5];
                choice9_4.text = data3[i][6];
                Answer9 = data3[i][1];
            }
        }
    }

    public void QuestionSelectorMultipleChoice2Answers(){
        Random random = new Random();

        string firstQ = random.Next(13,15).ToString();

        for (int i = 0; i<data2.Count; i++){
            if (data2[i][0] == firstQ){
                //function to replace text on test
                Question10.text = data2[i][3];
                choice10_1.text = data2[i][4];
                choice10_2.text = data2[i][5];
                choice10_3.text = data2[i][6];
                choice10_4.text = data2[i][7];
                Answer10_1 = data2[i][1];
                Answer10_2 = data2[i][2];
            }
        }
    }
}