using UnityEngine;

[CreateAssetMenu(fileName = "New Good", menuName = "Shop/Potion", order = 51)]
public class Potion : Good
{
    [SerializeField] private int _calories;
    public override void ShowInfo()
    {
        Debug.Log($"��������� ����� - {Label}, �������� - {Description}, ���� - {Price}, ������������ - {_calories}");
    }
}
