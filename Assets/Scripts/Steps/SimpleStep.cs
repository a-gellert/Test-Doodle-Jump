using UnityEngine;
public class SimpleStep : MonoBehaviour
{
    [SerializeField] private Bouncing _spring;
    [SerializeField] private Jetpack _jetPack;
    public void Init()
    {
        int r = Random.Range(0, 15);
        if (r < 3)
        {
            _spring.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-0.3f, 0.3f), _spring.GetComponent<Transform>().localPosition.y, _spring.GetComponent<Transform>().localPosition.z);
            _spring.GetComponent<Transform>().gameObject.SetActive(true);
        }
        else
        {
            _spring.GetComponent<Transform>().gameObject.SetActive(false);
        }
        if (r == 10)
        {
            _jetPack.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-0.3f, 0.3f), _spring.GetComponent<Transform>().localPosition.y, _spring.GetComponent<Transform>().localPosition.z);
            _jetPack.GetComponent<Transform>().gameObject.SetActive(true);
            _jetPack.Init(transform);
        }
        else if (!_jetPack.Isjet)
        {
            _jetPack.GetComponent<Transform>().gameObject.SetActive(false);
        }
    }

}
