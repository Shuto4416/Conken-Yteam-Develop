using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace Aramaki.Script.Player.Contorol {
    public class PlayerContorol : MonoBehaviour
    {
        [SerializeField] float speed = 5f;
        [SerializeField] float xBorder = 4.5f;
        [SerializeField] float y_up_Border = 7f;
        [SerializeField] float y_down_Border = -7f;
        [SerializeField] GameObject _bullet;
        private float _horizontal, _vertical;
        Vector3 pos,mousePos;
        // Start is called before the first frame update
        void Start()
        {
            pos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            GameObject bullet;
            mousePos = Input.mousePosition;
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
                if (transform.position.x>=-xBorder) transform.Translate(-1*speed*Time.deltaTime,0f,0f);
            } else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
                if (transform.position.x<=xBorder) transform.Translate(speed*Time.deltaTime,0f,0f);
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
                if (transform.position.y>=y_down_Border) transform.Translate(0f,-1*speed*Time.deltaTime,0f);
            } else if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
                if (transform.position.y<=y_up_Border) transform.Translate(0f,1*speed*Time.deltaTime,0f);
            }
            if (Input.GetMouseButtonDown(0)){
                bullet = Instantiate(_bullet,transform.position,Quaternion.identity);
                var pos = Camera.main.WorldToScreenPoint (bullet.transform.localPosition);
                var rotation = Quaternion.LookRotation(Vector3.up, Input.mousePosition - pos);
                bullet.transform.localRotation = rotation;
                //bullet.transform.LookAt(mousePos);
            }

        }
    }
}

