using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aramaki.Script.Bullet.Circle {
    public class CircleBullet : MonoBehaviour
    {
        public float angleSpeed; // 角度
         // 速度
        float angle = 0;
        Vector3 velocity; // 移動量

        void Start()
        {
            angle = transform.localEulerAngles.z;
            // 5秒後に削除
            Destroy(gameObject, 10.0f);
        }
        void Update()
        {
            float speed = angleSpeed;
             // X方向の移動量を設定する
            // 弾の向きを設定する
            //float zAngle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg - 90.0f;
            transform.rotation = Quaternion.Euler(0, 0, angle);
            // 毎フレーム、弾を移動させる
            transform.position += -transform.up * speed * Time.deltaTime;
            angle++;
        }
    }
}

