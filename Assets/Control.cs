using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private Camera mainCamera; // ���� ī�޶�
    private Vector3 destination; // ĳ������ �̵� ��ġ
    private bool Click; // Ŭ���� ���Դ��� Ȯ��

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    void Start()
    {
    }

    void Update()
    {
        // ���콺 �Է��� �޾� �� ��
        if (Input.GetMouseButton(1))
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
        Click = true;
    }

    private void Move()
    {
        if (Click)
        {
            var dir = destination-transform.position;
            transform.position += dir.normalized * Time.deltaTime * 10f;
        }
        if (Vector3.Distance(transform.position, destination) <= 0.1f)
        {
            Click = false;
        }
    }

}

