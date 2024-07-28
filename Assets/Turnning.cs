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
        direction = Random.Range(0, 360);  //0~360도 중 하나를 랜덤으로 정함
        transform.Rotate(new Vector3(0, direction, 0), Space.World); // 정해진 각도로 회전
        yield return new WaitForSecondsRealtime(5.0f); //이를 5초마다 시행
        Debug.Log(direction);
        StartCoroutine(Turndirection());
    }
}