using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Firebase;
using Firebase.Database;
using Firebase.Auth;

public class CountScoreFinal : MonoBehaviour
{
    public FirebaseAuth auth = FirebaseAuth.DefaultInstance;

    string user;

    public static int score = 0;
    DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

    void Start() {
        user = auth.CurrentUser.UserId.ToString();
    }

    public void getScore() {   
        //Question 1 
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question1/ToggleGroup1/ToggleTrue1").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer1 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question1/ToggleGroup1/ToggleTrue1/True").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question1/ToggleGroup1/ToggleFalse1").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer1 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question1/ToggleGroup1/ToggleFalse1/False").GetComponent<TMP_Text>().text) {
            score += 10;
        }

        //Question 2
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question2/ToggleGroup2/ToggleTrue2").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer2 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question2/ToggleGroup2/ToggleTrue2/True").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question2/ToggleGroup2/ToggleFalse2").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer2 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question2/ToggleGroup2/ToggleFalse2/False").GetComponent<TMP_Text>().text) {
            score += 10;
        }

        //Question 3
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/ToggleTrue3").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer3 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/ToggleTrue3/True").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/ToggleFalse3").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer3 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/ToggleFalse3/False").GetComponent<TMP_Text>().text) {
            score += 10;
        }

        //Question 4
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle1").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer4 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle1/Answer1").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle2").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer4 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle2/Answer2").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle3").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer4 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle3/Answer3").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle4").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer4 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle4/Answer4").GetComponent<TMP_Text>().text) {
            score += 10;
        }

        //Question 5
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle1").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer5 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle1/Answer1").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle2").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer5 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle2/Answer2").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle3").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer5 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle3/Answer3").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle4").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer5 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle4/Answer4").GetComponent<TMP_Text>().text) {
            score += 10;
        }

        //Question 6
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6/ToggleGroup6/Toggle1").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer6 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6/ToggleGroup6/Toggle1/Answer1").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6/ToggleGroup6/Toggle2").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer6 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6/ToggleGroup6/Toggle2/Answer2").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6/ToggleGroup6/Toggle3").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer6 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle3/Answer3").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6/ToggleGroup6/Toggle4").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer6 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question6/ToggleGroup6/Toggle4/Answer4").GetComponent<TMP_Text>().text) {
            score += 10;
        }

        //Question 7
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle1").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer7 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle1/Answer1").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle2").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer7 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle2/Answer2").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle3").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer7 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle3/Answer3").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle4").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer7 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question7/ToggleGroup7/Toggle4/Answer4").GetComponent<TMP_Text>().text) {
            score += 10;
        }

        //Question 8
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup8/Toggle1").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer8 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup8/Toggle1/Answer1").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup8/Toggle2").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer8 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup4/Toggle2/Answer2").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup8/Toggle3").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer8 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup8/Toggle3/Answer3").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup8/Toggle4").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer8 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question8/ToggleGroup8/Toggle4/Answer4").GetComponent<TMP_Text>().text) {
            score += 10;
        }

        //Question 9
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle1").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer9 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle1/Answer1").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle2").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer9 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle2/Answer2").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle3").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer9 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle3/Answer3").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle4").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer9 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question9/ToggleGroup9/Toggle4/Answer4").GetComponent<TMP_Text>().text) {
            score += 10;
        }

        //Question 10
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle1").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer10_1 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle1/Answer1").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle2").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer10_1 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle2/Answer2").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle3").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer10_1 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle3/Answer3").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle4").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer10_1 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle4/Answer4").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle1").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer10_2 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle1/Answer1").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle2").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer10_2 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle2/Answer2").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle3").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer10_2 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle3/Answer3").GetComponent<TMP_Text>().text) {
            score += 10;
        }
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle4").GetComponent<Toggle>().isOn && 
        SelectQuestionsFinal.Answer10_2 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question10/ToggleGroup10/Toggle4/Answer4").GetComponent<TMP_Text>().text) {
            score += 10;
        }

        WriteData(score);
    }
    public void WriteData (int score) {
        reference.Child("Users").Child(user).Child("score_all").SetRawJsonValueAsync(score.ToString());
    }
}
