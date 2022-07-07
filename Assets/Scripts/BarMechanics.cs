using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMechanics : MonoBehaviour
{
    public VariableIntSO barScoreSO;

    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collide");
        if (collision.gameObject.tag == "Ball")
        {
            barScoreSO.Value += 1;
        Debug.Log("ball");

        }
    }

    void Update()
    {
        
    }
}
