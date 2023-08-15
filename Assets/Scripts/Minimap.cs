using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform target; // Ссылка на объект (игрока), за которым будет следить миникарта
    public Vector3 offset; // Смещение между миникартой и целью

    private void LateUpdate()
    {
        transform.position = target.position + offset; // Положение миникарты следует за целью
    }
}
