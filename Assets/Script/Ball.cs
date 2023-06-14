using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveJumpPower;

    Rigidbody2D rigdbody;
    private bool isJump = true;

     void Awake()
    {
        rigdbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move() {
        // 첫번째 허들에서는 블루
        // 두번째 허들에서는 그린
        // 세번째 허들에서는 레드

        float horizontal =  Input.GetAxis("Horizontal");
        
        Vector3 Position = transform.position;
        Position.x += horizontal * Time.deltaTime * moveSpeed;
        transform.position = Position;
    }

    void Jump() {
        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            if (!isJump) {
                
                // 가속도가 붙는다??? 

                // ForceMode.Force; 질량을 사용해서, 연속적인 힘을 가한느 경우에 사용한다.
                // ForceMode.Acceleration; 질량을 무시하고, 연속적인 가속력을 가하는 경우에 사용한다.
                // ForceMode.Impulse; 질량을 사용해서, 순간적인 힘을 가하는 경우에 사용한다.
                // ForceMode.VelocityChange; 질량을 무시하고, 리지드바디에 순간적인 가속력을 주는 경우에 사용한다.
                // ForceMode2D.Force; 질량을 사용해서, 연속적인 힘을 가하는 경우에 사용한다.
                // ForceMode2D.Impulse; 질량을 사용해서, 순간적인 힘을 가하는 경우에 사용한다.
                rigdbody.AddForce(Vector2.up * moveJumpPower, ForceMode2D.Impulse); // (AddForce) 오브젝트에 일정한 힘을 주어 이동시키는 것이다.
                isJump = true;
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Bottom" || other.gameObject.tag == "Hurdle"){
            isJump = false;
        }
    }
}