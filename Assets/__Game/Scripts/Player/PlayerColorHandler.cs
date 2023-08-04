using UnityEngine;

namespace Assets.__Game.Scripts.Player
{
  [RequireComponent(typeof(PlayerCollisionHandler))]
  public class PlayerColorHandler : MonoBehaviour
  {
    private Renderer _renderer;

    private PlayerCollisionHandler _playerCollisionHandler;

    private void Awake()
    {
      _renderer = GetComponentInChildren<Renderer>();

      _playerCollisionHandler = GetComponent<PlayerCollisionHandler>();

      _playerCollisionHandler.OnObstacleCollided += SetRandomColor;
    }

    public void SetRandomColor()
    {
      float r = Random.Range(0f, 1f);
      float g = Random.Range(0f, 1f);
      float b = Random.Range(0f, 1f);

      Color randomColor = new(r, g, b);

      _renderer.material.color = randomColor;
    }
  }
}