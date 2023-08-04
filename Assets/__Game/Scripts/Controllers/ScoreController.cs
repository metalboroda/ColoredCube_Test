using System;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
  public event Action<int> OnScoreIncreased;

  public int Score { get; private set; }

  private void Awake()
  {
    Score = 0;
  }

  public void IncreaseScore(int score)
  {
    Score += score;

    OnScoreIncreased?.Invoke(Score);
  }
}