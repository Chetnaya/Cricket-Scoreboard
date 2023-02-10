using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int teamAScore = 0;
    public int teamBScore = 0;
    public Text teamAText;
    public Text teamBText;

    public void IncrementTeamAScore()
    {
        teamAScore++;
        teamAText.text = "Team A: " + teamAScore.ToString();
    }

    public void IncrementTeamBScore()
    {
        teamBScore++;
        teamBText.text = "Team B: " + teamBScore.ToString();
    }

    public void ResetScores()
    {
        teamAScore = 0;
        teamBScore = 0;
        teamAText.text = "Team A: " + teamAScore.ToString();
        teamBText.text = "Team B: " + teamBScore.ToString();
    }
}
