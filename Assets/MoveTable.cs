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
        //�I�u�W�F�N�g�̏���Z���W��ۑ�
        positionZ = transform.position.z;
    }

    private void Update()
    {
        //Z���W��U��������
        float zOffSet = Mathf.Sin(Time.time * speed) * amplitude;

        //�I�u�W�F�N�g�̈ʒu���X�V
        Vector3 newPosition = transform.position;
        newPosition.z = positionZ + zOffSet;
        transform.position = newPosition;
    }
}
