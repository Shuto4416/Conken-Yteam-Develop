using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

namespace Aramaki.Script.Motion.Circular {
    public class CircularMotion : MonoBehaviour
    {
        [SerializeField] float period = 1;
        [SerializeField] GameObject origin;
        [SerializeField] GameObject _target;
        float _time = -1;
        int _bulletCountdown = 0;
        [SerializeField] int FireRate = 1;
        [SerializeField] float radius = 0;
        [SerializeField] float startingPoint = 0;
        [SerializeField] GameObject _bullet;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            GameObject bullet;
            //transform.LookAt(origin.transform);
            float theta = Mathf.Deg2Rad * _time * (1 / period) + Mathf.Deg2Rad * startingPoint;
            float sin = Mathf.Sin(theta);
            float cos = Mathf.Cos(theta);
            transform.position = new Vector3(origin.transform.position.x - radius*cos, origin.transform.position.y - radius*sin, origin.transform.position.z);
            _time-= 2;
            //_time = _time*1.0001f;
            if ((_bulletCountdown % FireRate) == 0) {
                bullet = Instantiate(_bullet,transform.position,Quaternion.identity);
                bullet.transform.LookAt(_target.transform);
            }
            _bulletCountdown++;
        }
    }
}

