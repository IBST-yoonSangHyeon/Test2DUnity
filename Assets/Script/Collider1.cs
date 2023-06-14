using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider1 : MonoBehaviour
{   
    [SerializeField] private float Speed = 10f;
    SpriteRenderer mesh;
    Material mat;


    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<SpriteRenderer>();
        mat = mesh.material;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {
        if (Input.GetKey(KeyCode.Keypad4)) { // 왼쪽
            Debug.Log("4번 클릭" + "Collider1.cs");
            transform.Translate(Vector3.left * Speed * Time.deltaTime );
        } else if (Input.GetKey(KeyCode.Keypad6)) { // 오른 쪽
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.Keypad8)) { // 위
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.Keypad5)) { // 아래
            transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }
    }
    
    // 두 객체가 충돌 시 호출되는 함수
    private void OnCollisionEnter2D(Collision2D other) {
        // [게임오브젝트 접근 방법1]
        // name으로 접근
        if (other.gameObject.name == "Dynamic Sprite Collider2"){
            Debug.Log("충돌이닷! OnCollisionEnter2D");
            mat.color = new Color(255f, 0f, 0f); // 빨강색
        }

        // [게임오브젝트 접근 방법2]
        // tag으로 접근
        // if (other.gameObject.tag == "ColliderDefence") {
        //     Debug.Log("충돌이닷!");
        //     mat.color = new Color(0f, 0f, 0f);
        // }
    }

    // 두 객체가 충돌하는 동안 호출되는 함수
    private void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.name == "Dynamic Sprite Collider2"){
            Debug.Log("충돌이닷! OnCollisionStay2D");
            mat.color = new Color(0f, 0f, 255f);// 파란색
        }
    }

    // 두 객체가 충돌을 끝마치면 호출되는 함수
    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.name == "Dynamic Sprite Collider2"){
            Debug.Log("충돌이닷! OnCollisionExit2D");
            mat.color = new Color(0f, 0f, 0f); // 검정색
        }
    }

    // 두 객체가 충돌시 호출되는 함수
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Dynamic Sprite Collider2"){
            Debug.Log("충돌이닷! OnTriggerEnter2D");
            mat.color = new Color(255f, 204f, 204f); // 빨강색의 밝은 색
        }
    }

    // 두 객체가 충돌하는 동안 호출되는 함수
    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.name == "Dynamic Sprite Collider2"){
            Debug.Log("충돌이닷! OnTriggerStay2D");
            mat.color = new Color(229f, 204f, 255f);// 파란색의 밝은 색
            
        }
    }

    // 두 객체가 충돌이 끝마치면 호출되는 함수
    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.name == "Dynamic Sprite Collider2"){
            Debug.Log("충돌이닷! OnTriggerExit2D"); 
            mat.color = new Color(255f, 255f, 255f);// 흰색
        }
    }
}
