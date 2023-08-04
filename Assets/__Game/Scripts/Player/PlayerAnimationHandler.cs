using DG.Tweening;
using System;
using UnityEngine;

namespace Assets.__Game.Scripts.Player
{
  [RequireComponent(typeof(PlayerCollisionHandler))]
  public class PlayerAnimationHandler : MonoBehaviour
  {
    [Header("Scale Animation")]
    [SerializeField] private float _scaleMultiplier = 0.5f;
    [SerializeField] private float _scaleSpeed = 0.15f;

    private Vector3 _originalScale;
    private Sequence _bounceSequence;

    private PlayerCollisionHandler _playerCollisionHandler;

    private void Awake()
    {
      _playerCollisionHandler = GetComponent<PlayerCollisionHandler>();

      _playerCollisionHandler.OnObstacleCollided += ScaleAnimation;

      _originalScale = transform.lossyScale;
    }

    private void ScaleAnimation()
    {
      _bounceSequence = DOTween.Sequence();

      Vector3 newScale = new(_originalScale.x + _scaleMultiplier, _originalScale.y + _scaleMultiplier, _originalScale.z + _scaleMultiplier);

      _bounceSequence.Append(transform.DOScale(newScale, _scaleSpeed));
      _bounceSequence.Append(transform.DOScale(_originalScale, _scaleSpeed));
    }
  }
}