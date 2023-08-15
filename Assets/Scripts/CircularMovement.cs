using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    public Transform center; // Центр вокруг которого двигается предмет
    public float radius = 2f; // Радиус окружности
    public float speed = 1f; // Скорость вращения

    private float angle = 0f;

    private void Update()
    {
        angle += speed * Time.deltaTime; // Увеличиваем угол во времени

        // Вычисляем новую позицию предмета на окружности
        Vector3 newPosition = center.position + new Vector3(Mathf.Cos(angle) * radius, 0f, Mathf.Sin(angle) * radius);
        transform.position = newPosition;

        // Настроим ориентацию предмета к центру
        Vector3 lookAtPosition = center.position;
        lookAtPosition.y = transform.position.y; // Сохраняем высоту, чтобы не наклонять предмет
        transform.LookAt(lookAtPosition);
    }
}
