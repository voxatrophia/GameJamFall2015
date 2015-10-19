using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(ObjectPooler))]
public class PlayerController : MonoBehaviour {
    public float speed = 25f;
    public float jumpforce = 100f;


    ObjectPooler bullets;
    Rigidbody2D rb;
    Vector3 target;

    enum Actions { Null, Jump, Shoot, Freeze, Count }

    public int action = (int)Actions.Null;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        bullets = GetComponent<ObjectPooler>();
    }

    void OnEnable() {
        EventManager.StartListening(k_Triggers.Clear, ClearAction);
        EventManager.StartListening(k_Triggers.Jump, SetJump);
        EventManager.StartListening(k_Triggers.Shoot, SetShoot);
        EventManager.StartListening(k_Triggers.Freeze, SetFreeze);
    }

    void OnDisable() {
        EventManager.StopListening(k_Triggers.Clear, ClearAction);
        EventManager.StopListening(k_Triggers.Jump, SetJump);
        EventManager.StopListening(k_Triggers.Shoot, SetShoot);
        EventManager.StopListening(k_Triggers.Freeze, SetFreeze);
    }

    void ClearAction() {
        action = (int)Actions.Null;
    }

    void SetJump() {
        action = (int)Actions.Jump;
    }

    void SetShoot() {
        action = (int)Actions.Shoot;
    }

    void SetFreeze()
    {
        action = (int)Actions.Freeze;
    }


    void Update() {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (Input.GetButtonDown("Fire1")){
            switch (action)
            {
                case (int)Actions.Null:
                    break;
                case (int)Actions.Jump:
                    rb.AddForce(new Vector2(0, jumpforce));
                    break;
                case (int)Actions.Shoot:
                    Shoot(0);
                    break;
                case (int)Actions.Freeze:
                    Shoot(1);
                    break;
                default:
                    break;
            }
        }
    }

    void Shoot(int type) {
        GameObject go = bullets.GetPooledObject();
        if (go != null) {
            target = Input.mousePosition;
            target.z = transform.position.z - Camera.main.transform.position.z;
            target = Camera.main.ScreenToWorldPoint(target);

            string newTag = k_Tags.Bullet;
            switch (type)
            {
                case 0:
                    newTag = k_Tags.Bullet;
                    break;
                case 1:
                    newTag = k_Tags.Freeze;
                    break;
                default:
                    break;
            }
            go.tag = newTag;
            go.transform.position = transform.position;
            go.transform.rotation = Quaternion.FromToRotation(Vector3.up, target - go.transform.position);
            go.SetActive(true);
            Rigidbody2D goRB = go.GetComponent<Rigidbody2D>();
            goRB.AddForce(go.transform.up * 2000f);

        }
    }
}