﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGizmos : MonoBehaviour
{
    public Color _color = Color.yellow;
    public float _radius = 0.3f;

    private void OnDrawGizmos()
    {
        Gizmos.color = _color;
        Gizmos.DrawSphere(transform.position, _radius);
    }
}
