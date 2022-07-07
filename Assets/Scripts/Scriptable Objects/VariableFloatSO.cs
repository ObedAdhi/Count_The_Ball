using UnityEngine;

[CreateAssetMenu(fileName = "FloatVariableSO", menuName = "Count_The_Ball/FloatVariableSO", order = 0)]

public class VariableFloatSO : ScriptableObject
{
    [SerializeField] string variableName;
	public float Value;
}
