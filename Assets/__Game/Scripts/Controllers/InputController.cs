using UnityEngine;

namespace Assets.__Game.Scripts.Controllers
{
  public class InputController : MonoBehaviour
  {
    private CubeActions _inputActions;

    private void Awake()
    {
      _inputActions = new();

      _inputActions.General.Enable();
    }

    public Vector2 PlayerInputVector()
    {
      return _inputActions.General.Movement.ReadValue<Vector2>();
    }
  }
}