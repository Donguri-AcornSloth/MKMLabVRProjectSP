using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DrawingRoute : MonoBehaviour
{
    [SerializeField] CinemachinePath smoothPath;
    [SerializeField] CinemachinePath.PositionUnits units;
    [SerializeField] GameObject cube;
    [SerializeField] uint amount;

    void Start()
    {
        if (OnOffRail.isRail == true)
        {
            // 例: 3の時にこんな感じに o------o------o 両端になるようにamount-1

            float interval = smoothPath.PathLength / (amount - 1);

            Vector3 position;
            Quaternion rotation;
            for (float pos = 0; pos <= smoothPath.PathLength; pos += interval)
            {
                position = smoothPath.EvaluatePositionAtUnit(pos, units);
                rotation = smoothPath.EvaluateOrientationAtUnit(pos, units);
                Instantiate(cube, position, rotation, transform);
            }
        }
    }
}