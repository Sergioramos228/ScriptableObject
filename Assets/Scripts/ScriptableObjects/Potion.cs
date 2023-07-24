using UnityEngine;

[CreateAssetMenu(fileName = "New Good", menuName = "Shop/Potion", order = 51)]
public class Potion : Good
{
    [SerializeField] private int _calories;
    public override void ShowInfo()
    {
        Debug.Log($"Съедобный товар - {Label}, Описание - {Description}, Цена - {Price}, Калорийность - {_calories}");
    }
}
