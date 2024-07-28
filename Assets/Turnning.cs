using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnning : MonoBehaviour
{
    private int direction=0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Turndirection());
        
    }

    void Update()
    {

    }

    IEnumerator Turndirection()
    {
        direction = Random.Range(0, 360);  //0~360�� �� �ϳ��� �������� ����
        transform.Rotate(new Vector3(0, direction, 0), Space.World); // ������ ������ ȸ��
        yield return new WaitForSecondsRealtime(5.0f); //�̸� 5�ʸ��� ����
        Debug.Log(direction);
        StartCoroutine(Turndirection());
    }
}