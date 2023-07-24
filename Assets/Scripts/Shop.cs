using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<Good> _goods;
    private void Start()
    {
        foreach (Good good in _goods)
        {
            good.ShowInfo();
        }
    }
}
