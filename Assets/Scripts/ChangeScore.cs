using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeScore : MonoBehaviour
{
    [SerializeField]
    private TMP_Text Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("Canvas/Panel/ScoreDisplay").GetComponent<TMP_Text>();

        switch (ChangeScene.PreviousLevel){
            case "TestChapter1" :
                Score.text = CountScore1.score.ToString()+"/100";
                break;
            case "TestChapter2" :
                Score.text = CountScore2.score.ToString()+"/100";
                break;
            case "TestChapter3" :
                Score.text = CountScore3.score.ToString()+"/100";
                break;
            case "TestFinalRevision" :
                Score.text = CountScoreFinal.score.ToString()+"/100";
                break;
        }
    }
}
