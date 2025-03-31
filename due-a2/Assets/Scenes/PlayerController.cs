using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed = 45f; // 旋转角度（每次按按钮转 45 度）
    public float scaleFactor = 1.2f; // 缩放比例
    private Vector3 originalScale; // 记录初始大小
    private Quaternion originalRotation; // 记录初始旋转

    void Start()
    {
        originalScale = transform.localScale; // 存储初始大小
        originalRotation = transform.rotation; // 存储初始旋转
    }

    public void TurnLeft()
    {
        transform.eulerAngles += new Vector3(0, -turnSpeed, 0);
    }

    public void TurnRight()
    {
        transform.eulerAngles += new Vector3(0, turnSpeed, 0);
    }

    public void Grow()
    {
        transform.localScale *= scaleFactor;
    }

    public void Shrink()
    {
        transform.localScale /= scaleFactor;
    }

    public void ResetTransform()
    {
        transform.localScale = originalScale; // 还原大小
        transform.rotation = originalRotation; // 还原旋转
    }
}
