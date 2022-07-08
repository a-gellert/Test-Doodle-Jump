using DG.Tweening;
using UnityEngine;

public class MainMenuTweening : MonoBehaviour
{
    [SerializeField] private RectTransform _background;
    [SerializeField] private RectTransform _startNTitle;
    [SerializeField] private RectTransform _anim;
    [SerializeField] private RectTransform _backgroundA;
    [SerializeField] private RectTransform _backgroundB;
    [SerializeField] private RectTransform _startNTitleA;
    [SerializeField] private RectTransform _startNTitleB;
    [SerializeField] private RectTransform _animA;
    [SerializeField] private RectTransform _animB;
    public static MainMenuTweening Instance;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void OnPlayGame()
    {
        _background.DOMove(_backgroundB.position, 2f);
        _startNTitle.DOMove(_startNTitleB.position, 2f);
        _anim.DOMove(_animB.position, 2f);
    }
    public void OnMainMenu()
    {
        _background.DOMove(_backgroundA.position, 2f);
        _startNTitle.DOMove(_startNTitleA.position, 2f);
        _anim.DOMove(_animA.position, 2f);
    }
}
