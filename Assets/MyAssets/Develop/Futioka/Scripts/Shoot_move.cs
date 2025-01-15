using Unity.VisualScripting;
using UnityEngine;

public class Shoot_move : MonoBehaviour {

    [SerializeField] private float speed_sh = 10f;
    private Vector3 direction_sh;
    private Transform rangeA, rangeB;
    private GameObject user;
    private int color;

    private bool IsOutOfBounds(Vector3 position) {

        return position.x < (rangeA.position.x - 5.0f) || position.x > (rangeB.position.x + 5.0f) ||
            position.y > (rangeA.position.y + 5.0f) || position.y < (rangeB.position.y - 5.0f);
    }

    public void St(GameObject us, Transform a, Transform b, Vector3 di, int co) {
        
        rangeA = a;
        rangeB = b;

        user = us;

        direction_sh = di.normalized;

        color = co;
        if(color == 3){
            transform.localScale = new Vector3(2, 1, 1);

            float angle = Mathf.Atan2(direction_sh.y, direction_sh.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }

    }

    public void Update() {

        transform.position += Time.deltaTime * speed_sh * direction_sh;

        float a = 0.5f;

        if(color == 3){
            a = 1.0f;
        }

        if (IsOutOfBounds(transform.position) ||
        Vector2.Distance(transform.position, user.transform.position) < a)
        {
            Destroy(gameObject);
        }
    }
}
