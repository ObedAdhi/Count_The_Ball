using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    public VariableIntSO scoreTop;
    public VariableIntSO scoreLeft;
    public VariableIntSO scoreRight;
    public VariableIntSO scoreBottom;
    // public TMP_Text stringTop;
    // public TMP_Text stringLeft;
    // public TMP_Text stringRight;
    // public TMP_Text stringBottom;


    void Start()
    {
        Application.targetFrameRate = 90;
        // SetScoreUI();
    }

    void SetScoreUI()
    {
        // stringTop.text = "Top: " + scoreTop.Value.ToString();
        // stringLeft.text = "Left: " + scoreLeft.Value.ToString();
        // stringRight.text = "Right: " + scoreRight.Value.ToString();
        // stringBottom.text = "Bottom: " + scoreBottom.Value.ToString();
    }

    void Update()
    {
        
    }
}
