using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

namespace Aramaki.Script.Motion.Circular.Calc {
    public class CircularMotionCalc
    {
        Vector3 MotionCalc(Vector3 target, Vector3 origin, float _time, float period = 1, float startingPoint = 0, float radius = 0) {
            float theta = Mathf.Deg2Rad * _time * (1 / period) + Mathf.Deg2Rad * startingPoint;
            float sin = Mathf.Sin(theta);
            float cos = Mathf.Cos(theta);
            Vector3 _calcPosition = new Vector3();
            _calcPosition = new Vector3(origin.x - radius*cos, origin.y - radius*sin, origin.z);
            return _calcPosition;
        }
    }
}

