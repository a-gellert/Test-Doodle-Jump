using UnityEngine;
public class Jetpack : MonoBehaviour
{
    [SerializeField] private float _force = 20f;
    public bool Isjet { get; private set; } = false;
    private Transform _parent;
    public void Jet()
    {
        transform.SetParent(Player.Instance.transform);
        transform.localPosition = new Vector3(0, 0, 1);
        Player.Instance.rb.velocity = Vector2.up * _force;
        Isjet = true;
    }
    public void Init(Transform parent)
    {
        _parent = parent;
    }
    private void FixedUpdate()
    {
        if (Isjet && Player.Instance.rb.velocity.y < 2)
        {
            Debug.Log(1);
            Isjet = false;
            transform.SetParent(_parent);
            transform.gameObject.SetActive(false);
            Debug.Log(2);
        }
    }
}
