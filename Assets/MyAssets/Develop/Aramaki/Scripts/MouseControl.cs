using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aramaki.Script.Player.Mouse {
    public class MouseControl : MonoBehaviour
    {
        [SerializeField] float RotateSpeed = 1.0f;
        Vector3 mousePos, pos;
        // Start is called before the first frame update
        void Start()
        {
            Cursor.visible = false;
        }

        // Update is called once per frame
        void Update()
        {
            mousePos = Input.mousePosition;
            pos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10f));
            transform.position = pos;
            transform.Rotate(0, 0, RotateSpeed);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.visible = true;
            }
        }
    }
}