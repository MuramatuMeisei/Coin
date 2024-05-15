using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTable : MonoBehaviour
{
    public float speed = 2.0f;
    public float amplitude = 2f;

    private float positionZ;

    private void Start()
    {
        //オブジェクトの初期Z座標を保存
        positionZ = transform.position.z;
    }

    private void Update()
    {
        //Z座標を振動させる
        float zOffSet = Mathf.Sin(Time.time * speed) * amplitude;

        //オブジェクトの位置を更新
        Vector3 newPosition = transform.position;
        newPosition.z = positionZ + zOffSet;
        transform.position = newPosition;
    }
}
