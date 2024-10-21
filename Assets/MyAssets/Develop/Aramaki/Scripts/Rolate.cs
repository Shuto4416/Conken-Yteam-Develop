using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolate : MonoBehaviour
{
    float angle = 0;
    [SerializeField] float _angleSpeed;
    [SerializeField] GameObject _target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, angle * _angleSpeed);
        angle++;
        _target.transform.position = transform.up * 5f;
    }
}
