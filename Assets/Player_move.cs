using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    private Camera mainCamera; // 메인 카메라
    private Vector3 destination; // 캐릭터의 이동 위치
    private bool isMove; // 이동 명령이 들어왔는지 확인

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButton(1)) // 마우스 입력을 받았을 때
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

