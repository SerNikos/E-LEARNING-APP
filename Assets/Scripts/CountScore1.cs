using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CountScore1 : MonoBehaviour
{
    public static int score = 0;

    public void getScore() {   
        //Question 1 
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question1/ToggleGroup1/ToggleTrue1").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer1 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question1/ToggleGroup1/ToggleTrue1/True").GetComponent<TMP_Text>().text) {
            score += 20;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question1/ToggleGroup1/ToggleFalse1").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer1 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question1/ToggleGroup1/ToggleFalse1/False").GetComponent<TMP_Text>().text) {
            score += 20;
        }

        //Question 2
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question2/ToggleGroup2/ToggleTrue2").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer2 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question2/ToggleGroup2/ToggleTrue2/True").GetComponent<TMP_Text>().text) {
            score += 20;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question2/ToggleGroup2/ToggleFalse2").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer2 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question2/ToggleGroup2/ToggleFalse2/False").GetComponent<TMP_Text>().text) {
            score += 20;
        }

        //Question 3
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle1").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer3 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle1/Answer1").GetComponent<TMP_Text>().text) {
            score += 20;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle2").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer3 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle2/Answer2").GetComponent<TMP_Text>().text) {
            score += 20;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle3").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer3 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle3/Answer3").GetComponent<TMP_Text>().text) {
            score += 20;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle4").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer3 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle4/Answer4").GetComponent<TMP_Text>().text) {
            score += 20;
        }

        //Question 4
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle1").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer4 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle1/Answer1").GetComponent<TMP_Text>().text) {
            score += 20;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle2").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer4 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle2/Answer2").GetComponent<TMP_Text>().text) {
            score += 20;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle3").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer4 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle3/Answer3").GetComponent<TMP_Text>().text) {
            score += 20;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle4").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer4 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle4/Answer4").GetComponent<TMP_Text>().text) {
            score += 20;
        }

        //Question 5
        if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle1").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer5 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle1/Answer1").GetComponent<TMP_Text>().text) {
            score += 20;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle2").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer5 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle2/Answer2").GetComponent<TMP_Text>().text) {
            score += 20;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle3").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer5 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle3/Answer3").GetComponent<TMP_Text>().text) {
            score += 20;
        }
        else if (GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle4").GetComponent<Toggle>().isOn && 
        SelectQuestions1.Answer5 == GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle4/Answer4").GetComponent<TMP_Text>().text) {
            score += 20;
        }
    }
}
