using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackPanel : MonoBehaviour
{
    public GameObject goodpanel, badpanel;

    public void ShowFeedbackPanel (int grade) {
        if (grade >= 50)
        {
            if (badpanel)
            {
                badpanel.SetActive(false);
            }
            goodpanel.SetActive(true);
        }
        else
        {
            if (goodpanel)
            {
                goodpanel.SetActive(false);
            }
            badpanel.SetActive(true);
        }
    }

}
