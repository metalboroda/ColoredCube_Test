using System;
using UnityEngine;
using Zenject;

namespace Assets.__Game.Scripts.Player
{
  public class PlayerCollisionHandler : MonoBehaviour
  {
    public event Action OnObstacleCollided;

    [Inject] ScoreController _scoreController;

    private void OnTriggerEnter(Collider other)
    {
      if (other.TryGetComponent(out IObstacle obstacle))
      {
        obstacle.Collision();

        _scoreController.IncreaseScore(1);

        OnObstacleCollided?.Invoke();

        Debug.Log(other.name);
      }
    }
  }
}