using UnityEngine;

[CreateAssetMenu(fileName = "New Good", menuName = "Shop/Sword", order = 51)]
public class Sword : Good
{
    [SerializeField] private int _damage;
    public override void ShowInfo()
    {
        Debug.Log($"������ - {Label}, �������� - {Description}, ���� - {Price}, ���� - {_damage}");
    }
}
