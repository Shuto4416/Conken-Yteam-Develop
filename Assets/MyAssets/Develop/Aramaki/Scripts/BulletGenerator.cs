using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Aramaki.Script.Bullet.Circle;
using System.Globalization;

namespace Aramaki.Script.Bullet.Generator {
    public class BulletGenerator : MonoBehaviour
    {
        [SerializeField] GameObject _prefab;
        int _num = 0;
        int _num2 = 1;
        GameObject _prefabCatcher;
        float _angle;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            _angle = transform.localEulerAngles.z;
            _prefabCatcher = Instantiate(_prefab,transform.position,Quaternion.Euler(0, 0, _angle)) as GameObject;
            CircleBullet _circleBullet = _prefabCatcher.GetComponent<CircleBullet>();
            _num++;
            _circleBullet.angleSpeed = 0.3f * (3 * (_num % 5) + 1 + _num2/2);
            transform.rotation = Quaternion.Euler(0, 0, _num * 17);
            if (_num % 10 == 0) _num2++;
            if (_num % 360 == 0) _num2 = 1;
        }
    }
}

