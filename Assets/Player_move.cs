using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    private Camera mainCamera; // ���� ī�޶�
    private Vector3 destination; // ĳ������ �̵� ��ġ
    private bool isMove; // �̵� ����� ���Դ��� Ȯ��

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButton(1)) // ���콺 �Է��� �޾��� ��
        {

            RaycastHit hit;
            if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                SetDestination(hit.point);
            }
        }
        Move();

    }

    private void SetDestination(Vector3 dest)
    {
        destination = dest;
        isMove = true;
    }

    private void Move()
    {
        if (isMove)
        {
            var dir = destination-transform.position;
            transform.position += dir.normalized * Time.deltaTime * 10f;
        }
        if (Vector3.Distance(transform.position, destination) <= 0.1f)
        {
            isMove=false;
        }
    }

}

