using Assets.__Game.Scripts.Controllers;
using UnityEngine;
using Zenject;

namespace Assets.__Game.Scripts.Player
{
  public class PlayerMovement : MonoBehaviour
  {
    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] private float movementLimitX = 7.5f;
    [SerializeField] private float movementLimitZ = 7.5f;

    [Inject] private InputController _inputController;

    private void Update()
    {
      Movement();
    }

    private void Movement()
    {
      Vector2 dir = _inputController.PlayerInputVector();

      Vector3 movement = new Vector3(dir.x, 0, dir.y).normalized * movementSpeed * Time.deltaTime;
      Vector3 newPosition = transform.position + movement;

      newPosition.x = Mathf.Clamp(newPosition.x, -movementLimitX, movementLimitX);
      newPosition.z = Mathf.Clamp(newPosition.z, -movementLimitZ, movementLimitZ);

      transform.position = newPosition;
    }
  }
}