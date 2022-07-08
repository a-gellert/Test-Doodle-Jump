using System.Collections.Generic;
using UnityEngine;

public class StepManager : MonoBehaviour
{
    [SerializeField] private List<SimpleStep> _simpleSteps;
    [SerializeField] private List<MovingStep> _movingSteps;
    [SerializeField] private List<CrackStep> _crackSteps;
    private float _minX = -2.3f;
    private float _maxX = 2.3f;
    private float _minY = 1f;
    private float _maxY = 2f;
    private float _currentY;
    public static StepManager Instance;
    void Start()
    {
        RestartGame();
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Update()
    {
        CheckDestination();
    }
    public void RestartGame()
    {
        _currentY = 0;
        for (int i = 0; i < _simpleSteps.Count; i++)
        {
            SetSimpleStep(i);
        }
    }
    private void CheckDestination()
    {
        for (int i = 0; i < _simpleSteps.Count; i++)
        {
            if (transform.position.y - _simpleSteps[i].transform.position.y > 6)
            {
                SetSimpleStep(i);

            }
        }
        for (int i = 0; i < _movingSteps.Count; i++)
        {
            if (transform.position.y - _movingSteps[i].transform.position.y > 6)
            {
                if (Random.Range(0, 10) < 1)
                {
                    SetMovingStep(i);
                }
                else
                {
                    _movingSteps[i].transform.position = new Vector3(-10, transform.position.y, 0);
                }
            }
        }
        for (int i = 0; i < _crackSteps.Count; i++)
        {
            if (transform.position.y - _crackSteps[i].transform.position.y > 6)
            {
                if (Random.Range(0, 10) < 1)
                {
                    SetCrackStep(i);
                }
                else
                {
                    _crackSteps[i].transform.position = new Vector3(-20, transform.position.y, 0);
                }
                _crackSteps[i].Init();
            }
        }
    }
    private void SetSimpleStep(int i)
    {
        _simpleSteps[i].transform.position = SetPosition();
        _simpleSteps[i].transform.SetParent(null);
        _simpleSteps[i].Init();
        _currentY++;
    }
    private void SetMovingStep(int i)
    {
        var position = SetPosition();
        _movingSteps[i].transform.position = new Vector3(0, position.y, 0);
        _movingSteps[i].transform.SetParent(null);
        _currentY++;
    }
    private void SetCrackStep(int i)
    {
        _crackSteps[i].transform.position = SetPosition();
        _crackSteps[i].transform.SetParent(null);
    }
    private Vector2 SetPosition()
    {
        float x = Random.Range(_minX, _maxX);
        float y = Random.Range(_minY, _maxY) + _currentY;
        return new Vector2(x, y);
    }
}
