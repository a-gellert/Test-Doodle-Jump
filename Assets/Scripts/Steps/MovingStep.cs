using UnityEngine;
public class MovingStep : MonoBehaviour
{
    [SerializeField] private float _xDistance = 2.3f;
    [SerializeField] private float _xVelocity = 1f;
    private void FixedUpdate()
    {
        transform.Translate(_xVelocity * Time.deltaTime, 0, 0, Space.Self);
        Move();
    }

    private void Move()
    {
        if (Mathf.Abs(transform.position.x - 0) > _xDistance)
        {
            _xVelocity = -_xVelocity;
        }
    }
}
