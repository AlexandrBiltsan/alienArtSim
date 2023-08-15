using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    public Transform center;
    public float radius = 2f;
    public float speed = 1f;

    private float angle = 0f;
    public float smoothness = 5f; // Параметр плавности

    private void Update()
    {
        angle += speed * Time.deltaTime;

        Vector3 targetPosition = center.position + new Vector3(Mathf.Cos(angle) * radius, 0f, Mathf.Sin(angle) * radius);

        // Интерполируем плавное перемещение от текущей позиции к целевой
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothness);

        Vector3 lookAtPosition = center.position;
        lookAtPosition.y = transform.position.y;
        transform.LookAt(lookAtPosition);
    }
}






