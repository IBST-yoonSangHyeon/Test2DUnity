using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsulte_A : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {
        // [실험] 키보드 다운
        // if (Input.GetKey(KeyCode.LeftArrow)){ // 꾹 누르면 계속 실행, 한번 눌러도 실행
        //     Debug.Log("왼쪽 화살표 키 GetKey ");
        // } else if (Input.GetKey(KeyCode.RightArrow)) { // 꾹 누르면 계속 실행, 한번 눌러도 실행
        //     Debug.Log("오른쪽 화살표 키 GetKey ");
        // } 
        // if (Input.GetKeyDown(KeyCode.LeftArrow)) { // 꾹 누르면 계속 실행 안됨, 한번 누르면 실행
        //     Debug.Log("왼쪽 화살표 키 GetKeyDown ");
        // } else if (Input.GetKeyDown(KeyCode.RightArrow)) { // 꾹 누르면 계속 실행 안됨, 한번 누르면 실행
        //     Debug.Log("오른쪽 화살표 키 GetKeyDown ");
        // } 

        // if (Input.GetKeyUp(KeyCode.LeftArrow)) { // 키보드에서 손을 떼면 실행됨
        //     Debug.Log("왼쪽 화살표 키 GetKeyDown ");
        // } else if (Input.GetKeyUp(KeyCode.RightArrow)) { // 키보드에서 손을 떼면 실행됨
        //     Debug.Log("오른쪽 화살표 키 GetKeyDown ");
        // }

        // Debug.Log("Move 실행중?"); // 계속 실행되는 것을 알게됨.  

        // [실험] 1. 키보드 사물 이동 (인터넷 검색 해보니 이동하는게 아주 많음...ㅡ.ㅡ;;;;;)
        if (Input.GetKey(KeyCode.LeftArrow)){ 
            Debug.Log("왼쪽 화살표 키 GetKey ");
            Debug.Log("transform.position : " + transform.position);
            Debug.Log("Vector3.left : " + Vector3.left);
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.RightArrow)) { 
            Debug.Log("오른쪽 화살표 키 GetKey ");
            Debug.Log("transform.position : " + transform.position);
            Debug.Log("Vector3.right : " + Vector3.right);
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("위 화살표 키 GetKey ");
            Debug.Log("transform.position : " + transform.position);
            Debug.Log("Vector3.up : " + Vector3.up);
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("아래 화살표 키 GetKey ");
            Debug.Log("transform.position : " + transform.position);
            Debug.Log("Vector3.down : " + Vector3.down);
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
    }
}
