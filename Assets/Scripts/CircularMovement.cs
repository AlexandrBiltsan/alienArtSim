using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    public Transform center; // ����� ������ �������� ��������� �������
    public float radius = 2f; // ������ ����������
    public float speed = 1f; // �������� ��������

    private float angle = 0f;

    private void Update()
    {
        angle += speed * Time.deltaTime; // ����������� ���� �� �������

        // ��������� ����� ������� �������� �� ����������
        Vector3 newPosition = center.position + new Vector3(Mathf.Cos(angle) * radius, 0f, Mathf.Sin(angle) * radius);
        transform.position = newPosition;

        // �������� ���������� �������� � ������
        Vector3 lookAtPosition = center.position;
        lookAtPosition.y = transform.position.y; // ��������� ������, ����� �� ��������� �������
        transform.LookAt(lookAtPosition);
    }
}
