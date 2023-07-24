using UnityEngine;

//[CreateAssetMenu(fileName = "New Good", menuName = "Good", order = 51)]
public abstract class Good : ScriptableObject
{
    [SerializeField] protected string Label;
    [SerializeField] protected string Description;
    [SerializeField] protected int Price;

    public abstract void ShowInfo();
        //Debug.Log($"�������� - {_label}, �������� - {_description}, ���� - {_price}");
}
