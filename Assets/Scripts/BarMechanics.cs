using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BarMechanics : MonoBehaviour
{
    public TMP_Text textUI;
    public VariableIntSO barScoreSO;

    void Start()
    {
        SetUIText();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collide");
        if (collision.gameObject.tag == "Ball")
        {
            barScoreSO.Value += 1;
            SetUIText();
            Debug.Log("ball");
            Destroy(collision.collider.gameObject);
        }
    }

    void SetUIText() {
        textUI.text = barScoreSO.variableName + ": " + barScoreSO.Value.ToString();
    }

    void Update()
    {
        
    }
}
