using Assets.__Game.Scripts.Controllers;
using UnityEngine;
using Zenject;

namespace Assets.__Game.Scripts.Installers
{
  public class ControllerInstaller : MonoInstaller
  {
    [SerializeField] private ScoreController scoreController;
    [SerializeField] private InputController inputController;
    [SerializeField] private UIController uiController;

    public override void InstallBindings()
    {
      Container.Bind<ScoreController>().FromComponentInHierarchy(scoreController).AsSingle();
      Container.Bind<InputController>().FromComponentInHierarchy(inputController).AsSingle();
      Container.Bind<UIController>().FromComponentInHierarchy(uiController).AsSingle();
    }
  }
}