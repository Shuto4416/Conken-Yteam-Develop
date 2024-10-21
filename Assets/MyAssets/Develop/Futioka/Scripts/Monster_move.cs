using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_move : MonoBehaviour
{
    private GameObject us;
    [SerializeField] private float speed; // 敵の動くスピード

    public void Start(){
        us = GameObject.Find("User");
    }
    public void Update() {
        
        if (Vector2.Distance(transform.position, us.transform.position) < 0.1f){
            return;
        }

        Vector3 direction = new Vector3(us.transform.position.x - transform.position.x, us.transform.position.y - transform.position.y, 0).normalized;

        // 敵をusの方向に向ける（回転）
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Euler(0, 0, targetRotation.eulerAngles.z);

        // 毎フレーム、usに向かって移動
        transform.position += direction * speed * Time.deltaTime;
    }
}
