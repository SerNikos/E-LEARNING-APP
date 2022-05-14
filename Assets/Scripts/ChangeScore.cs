using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeScore : MonoBehaviour
{
    [SerializeField]
    private TMP_Text Score;

    public FeedbackPanel scriptfb;

    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("Canvas/Panel/ScoreDisplay").GetComponent<TMP_Text>();

        scriptfb = FindObjectOfType<FeedbackPanel>();

        switch (ChangeScene.PreviousLevel){
            case "TestChapter1" :
                Score.text = CountScore1.score.ToString()+"/100";
                scriptfb.ShowFeedbackPanel(Int32.Parse(CountScore1.score.ToString()));
                break;
            case "TestChapter2" :
                Score.text = CountScore2.score.ToString()+"/100";
                scriptfb.ShowFeedbackPanel(Int32.Parse(CountScore2.score.ToString()));
                break;
            case "TestChapter3" :
                Score.text = CountScore3.score.ToString()+"/100";
                scriptfb.ShowFeedbackPanel(Int32.Parse(CountScore3.score.ToString()));
                break;
            case "TestFinalRevision" :
                Score.text = CountScoreFinal.score.ToString()+"/100";
                scriptfb.ShowFeedbackPanel(Int32.Parse(CountScoreFinal.score.ToString()));
                break;
        }
    }
}
