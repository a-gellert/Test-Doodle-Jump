using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void OnStart()
    {
        Player.Instance.RestartGame();
        MainMenuTweening.Instance.OnPlayGame();
    }
    public void OnRestart()
    {
        PauseMenuTweening.Instance.OnExitFromMenu();
        CameraController.Instance.transform.position = new Vector3(0, 0, -10);
        Player.Instance.RestartGame();
        StepManager.Instance.RestartGame();
    }
    public void OnPause()
    {
        Player.Instance.PauseGame();
        PauseMenuTweening.Instance.OnPause();
    }
    public void OnMenu()
    {
        PauseMenuTweening.Instance.OnExitFromMenu();
        MainMenuTweening.Instance.OnMainMenu();
    }
    public void OnResume()
    {
        PauseMenuTweening.Instance.OnExitFromMenu();
        Player.Instance.StartGame();
    }
}
