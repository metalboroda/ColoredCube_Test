using TMPro;
using UnityEngine;
using Zenject;

namespace Assets.__Game.Scripts.Controllers
{
  public class UIController : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI collisionText;

    [Inject] private ScoreController _scoreController;

    private void Awake()
    {
      _scoreController.OnScoreIncreased += DisplayScoreText;
    }

    private void DisplayScoreText(int score)
    {
      collisionText.SetText(score.ToString());
    }
  }
}