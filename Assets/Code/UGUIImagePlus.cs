using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UGUIImagePlus : Image {
    PolygonCollider2D collider;

    void Awake()
    {
        collider = GetComponent<PolygonCollider2D>();
    }

    public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
    {
        bool inside = collider.OverlapPoint(screenPoint);
        return inside;
    }
}
