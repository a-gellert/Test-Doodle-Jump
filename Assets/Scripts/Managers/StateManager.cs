using UnityEngine;

public class StateManager : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text _scoreInGame;
    [SerializeField] private TMPro.TMP_Text _scoreOnPauseMenu;
    [SerializeField] private TMPro.TMP_Text _highScoreOnMainMenu;
    [SerializeField] private SaveLoad _sl;

    private int _score;
    private int _highScore;

    private void Start()
    {
        _highScore = _sl.LoadCount();
        _highScoreOnMainMenu.text = _highScore.ToString();
    }
    void Update()
    {
        _score = Mathf.FloorToInt(Player.Instance.YDistance * 15);
        _scoreInGame.text = _score.ToString();
        _scoreOnPauseMenu.text = _scoreInGame.text;
        if (Player.Instance.IsOver && _highScore < _score)
        {
            _highScore = _score;
            _sl.SaveCount(_highScore);
            _highScoreOnMainMenu.text = _highScore.ToString();
        }
    }
}
