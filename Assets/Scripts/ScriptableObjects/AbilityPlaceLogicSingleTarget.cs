using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/Place Logic/Single Target")]
public class AbilityPlaceLogicSingleTarget : AbilityPlaceLogic
{
    public override List<Unit> TryGetTargets(Vector2 screenPoint)
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(screenPoint.x, screenPoint.y, 1));

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 15))
        {
            if (hit.transform.GetComponent<Unit>())
            {
                return new List<Unit>() { hit.transform.gameObject.GetComponent<Unit>()};
            }
        }

        return null;
    }
}
