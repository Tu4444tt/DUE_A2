using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed = 45f; // ��ת�Ƕȣ�ÿ�ΰ���ťת 45 �ȣ�
    public float scaleFactor = 1.2f; // ���ű���
    private Vector3 originalScale; // ��¼��ʼ��С
    private Quaternion originalRotation; // ��¼��ʼ��ת

    void Start()
    {
        originalScale = transform.localScale; // �洢��ʼ��С
        originalRotation = transform.rotation; // �洢��ʼ��ת
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
        transform.localScale = originalScale; // ��ԭ��С
        transform.rotation = originalRotation; // ��ԭ��ת
    }
}
