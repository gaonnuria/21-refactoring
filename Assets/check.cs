using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    private Transform player_position;
    public static int score_value;

    void Start()
    {
        player_position = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    
    // Update is called once per frame
    void Update()
    {
        back_check();
    }
    void back_check()
    {
        if (Vector3.Distance(transform.position,player_position.position)<=0.1f)
        {
            score_value++;
        }
    }
}
