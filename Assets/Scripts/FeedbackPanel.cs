using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackPanel : MonoBehaviour
{
    public int grade;
    public GameObject goodpanel, badpanel;
  
    void Start()
    {
        //logic here we need to find the grade varable from the database
        if (grade >= 50)
        {
            goodpanel.SetActive(true);
        }
        else
        {
            badpanel.SetActive(true);
        }
    }

}
