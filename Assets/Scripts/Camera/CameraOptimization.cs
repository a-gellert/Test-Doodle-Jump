using UnityEngine;
public class CameraOptimization : MonoBehaviour
{
    public Vector2 DefaultResolution = new Vector2(720, 1280);
    [Range(0f, 1f)] public float WidthOrHeight = 0;
    private Camera componentCamera;
    private float initialSize;
    private float targetAspect;

    private void Start()
    {
        componentCamera = GetComponent<Camera>();
        initialSize = componentCamera.orthographicSize;
        targetAspect = DefaultResolution.x / DefaultResolution.y;
    }
    private void Update()
    {
        float constantWidthSize = initialSize * (targetAspect / componentCamera.aspect);
        componentCamera.orthographicSize = Mathf.Lerp(constantWidthSize, initialSize, WidthOrHeight);
    }

}
