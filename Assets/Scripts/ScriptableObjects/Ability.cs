using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/New Ability")]
public class Ability : ScriptableObject
{
    [SerializeField] private AbilityPlaceLogic _placeLogic;
    [SerializeField] private List<AbilityAction> _abilityAction;
    public void ApplyAction(List<Unit> targets)
    {
        foreach (AbilityAction action in _abilityAction)
        {
            foreach (Unit target in targets)
            {
                action.Action(target);
            }
        }
    }

    public List<Unit> SelectTargets(Vector2 screenPoint)
    {
        return _placeLogic.TryGetTargets(screenPoint);
    }
}
