using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomClass : MonoBehaviour
{
    public HitAbleObject[] hitAbleObject;
    [ContextMenu("������")]
    public void Hit()
    {
        transform.GetComponent<HitAbleObject>().Hit();
        foreach (HitAbleObject hObject in hitAbleObject)
        {
            hObject.Hit();
        }
    }
}
