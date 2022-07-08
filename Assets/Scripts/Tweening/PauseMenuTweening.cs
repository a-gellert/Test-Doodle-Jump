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
    }

    public void OnPause()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_menu.DOMove(_menuPointA.position, 1f));
        sequence.OnComplete(Show);
    }
    public void OnExitFromMenu()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_menu.DOMove(_menuPointB.position, 1f));
        sequence.OnComplete(Show2);

    }
    private void Show()
    {
        // Debug.Log(1);
    }

    private void Show2()
    {
        // Debug.Log(2);

    }
}
