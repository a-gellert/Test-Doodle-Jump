using DG.Tweening;
using UnityEngine;

public class PauseMenuTweening : MonoBehaviour
{
    [SerializeField] private RectTransform _menu;
    [SerializeField] private RectTransform _menuPointA;
    [SerializeField] private RectTransform _menuPointB;

    public static PauseMenuTweening Instance;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        DOTween.Init();
    }

    public void OnPause()
    {
        _menu.DOMove(_menuPointA.position, 2f);
    }
    public void OnExitFromMenu()
    {

        _menu.DOMove(_menuPointB.position, 2f);

    }
}
