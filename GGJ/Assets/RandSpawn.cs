﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSpawn : MonoBehaviour {

    public Vector3 PointB;
    public Vector3 PointA;

    IEnumerator Start()
    {
        Vector3 pointA = transform.position;
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, PointA, PointB, 3));
            yield return StartCoroutine(MoveObject(transform, PointB, PointA, 3));
        }
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        float i = 0.0f;
        float rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }
}
