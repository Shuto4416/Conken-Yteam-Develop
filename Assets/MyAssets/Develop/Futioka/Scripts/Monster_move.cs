using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Monster_move : MonoBehaviour
{
    [SerializeField] [Tooltip("敵の速度")]private float speed = 5.0f;
    [SerializeField] [Tooltip("敵が弾を打つ間隔")]private float shoot_time = 2.0f; 
    [SerializeField] private Shoot_move shoot_move;
    [SerializeField] private GameObject shoot;
    private Material[] shoot_material;
    private Vector3 direction;
    private GameObject user, master;
    private Transform a,b;
    private float time;
    private SetMaterial set;
    private int color;

    public void St(GameObject us, GameObject mas, Transform A, Transform B, int co, Material[] m){

        user = us;
        master = mas;
        set = master.GetComponent<SetMaterial>();
        color = co;

        shoot_material = m;

        a = A;
        b = B;

        time = shoot_time;
    }

    public void Update() {

        direction = new Vector3(user.transform.position.x - transform.position.x, user.transform.position.y - transform.position.y, 0).normalized;
        // userに向かって移動
        transform.position += Time.deltaTime * speed * direction;

        if(time > shoot_time){
            float distanceToUser = Mathf.Sqrt(Mathf.Pow(transform.position.x - user.transform.position.x, 2) + Mathf.Pow(transform.position.y - user.transform.position.y, 2));
            if (distanceToUser > 20f){
                
                GameObject sh = Instantiate(shoot, transform.position, Quaternion.identity); //弾のPrefab生成
                shoot_move = sh.GetComponent<Shoot_move>();
                sh.GetComponent<MeshRenderer>().material = shoot_material[color];
                shoot_move.St(user, a, b, direction, color);

                time = 0f;
            }
        }

        if (Vector2.Distance(transform.position, user.transform.position) < 2.0f){
            Destroy(gameObject);
            set.monster_deleted();
        }//仮置き

        time += Time.deltaTime;
    }
}
