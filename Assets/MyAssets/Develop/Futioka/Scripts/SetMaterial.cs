using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class SetMaterial : MonoBehaviour
{
    [SerializeField] private GameObject enemy, user;
    [SerializeField] [Tooltip("敵のマテリアル")] private Material[] enemy_material; 
    [SerializeField] [Tooltip("生成する範囲")] private Transform rangeA, rangeB;
    [SerializeField] [Tooltip("自機の周囲で生成しない範囲の半径")] private float exclusionRadius;

    [SerializeField] [Tooltip("生成する間隔")] private float timing;
    [SerializeField] [Tooltip("敵の出場上限")] private float monster_limit;

    private float time; //経過時間

    private int counter = 0;//敵の数

    void Start(){
        time = timing;
    }

    float[] Ran(){

        float pl_x, pl_y, a, b;
        
        pl_x = Random.Range(rangeA.position.x, rangeB.position.x);
        a = Mathf.Abs(pl_x - user.transform.position.x);

        pl_y = Random.Range(rangeA.position.y, rangeB.position.y);
        b = Mathf.Abs(pl_y - user.transform.position.y);

        float distanceToUser = Mathf.Sqrt(Mathf.Pow(pl_x - user.transform.position.x, 2) + Mathf.Pow(pl_y - user.transform.position.y, 2));
        
        if(distanceToUser < exclusionRadius){
            return Ran();
        }
        else{
            float[] pl = {pl_x, pl_y}; 
            return pl;
        }
    }
    void Update()
    {
        if(counter < monster_limit){

            time += Time.deltaTime;

            if(time > timing)
            {
                float[] a = Ran();
            
                float x = a[0];
                float y = a[1];

                Vector3 pos = new (x, y, 0);

                int ColorNo = Random.Range(0, enemy_material.Length);
                GameObject en = Instantiate(enemy, pos, Quaternion.identity);
                en.GetComponent<MeshRenderer>().material = enemy_material[ColorNo];

                time = 0f;
                counter++;
            }  
        }
    }
}