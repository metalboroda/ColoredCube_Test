using DG.Tweening;
using UnityEngine;

namespace Assets.__Game.Scripts.Items
{
  public class ObstacleHandler : MonoBehaviour, IObstacle
  {
    [SerializeField] private float moveRadius = 5f;
    [SerializeField] private float minMoveRadius = 3f;

    private Collider _coll;

    private void Awake()
    {
      _coll = GetComponent<Collider>();
    }

    public void Collision()
    {
      _coll.enabled = false;

      float originalY = transform.position.y;

      Vector3 newPos;
      do
      {
        float randomX = Random.Range(-moveRadius, moveRadius);
        float randomZ = Random.Range(-moveRadius, moveRadius);

        newPos = new Vector3(randomX, originalY, randomZ);
      }
      while (Vector3.Distance(newPos, transform.position) < minMoveRadius);

      transform.DOMove(newPos, 0).OnComplete(() =>
      {
        _coll.enabled = true;
      });
    }
  }
}
