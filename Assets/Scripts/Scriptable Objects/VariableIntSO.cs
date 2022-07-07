using UnityEngine;

[CreateAssetMenu(fileName = "IntVariableSO", menuName = "Count_The_Ball/IntVariableSO", order = 0)]

public class VariableIntSO : ScriptableObject
{
    [SerializeField] string variableName;
	public int Value;
}

