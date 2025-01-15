using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aramaki.Script.Bullet.Simple {
    public class SimpleBullet : MonoBehaviour
    {
        [SerializeField] float _bulletSpeed = 20f;
        // Start is called before the first frame update
        void Start()
        {
            Destroy(gameObject, 5.0f);
        }

        // Update is called once per frame
        void Update()
        {
            transform.position += transform.forward * _bulletSpeed * Time.deltaTime;
        }
    }
}
