using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class playerControll : MonoBehaviour
{
    public GameObject success;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject btn4;
    public GameObject successimage;
    public float Speed;
    Rigidbody2D rigid;
    float h;
    float v;
    bool isHorizonMove;
    Vector3 dirVec;
   
    
    //Mobile key va r
    float up_Value;
    float down_Value;
    float left_Value;
    float right_Value;
    bool up_Down;
    bool down_Down;
    bool left_Down;
    bool right_Down;
    bool up_Up;
    bool down_Up;
    bool left_Up;
    bool right_Up;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal") + right_Value + left_Value;
        v = Input.GetAxisRaw("Vertical") + up_Value + down_Value;
        Debug.Log("업데이트 함수:" + up_Value);
        Debug.Log("업데이트 함수:" + down_Value);

        bool hDown =  right_Down || left_Down;
        bool vDown = up_Down || down_Down;
        bool hUp =  right_Up || left_Up;
        bool vUp =  up_Up || down_Up;

        Debug.Log("Input.GetButtonDown:" + Input.GetButtonDown("Vertical"));
        Debug.Log("down_Down:" + down_Down);

        if (hDown)
        {
            isHorizonMove = true;
            Debug.Log("hdown:" + isHorizonMove);

        }
        else if (vDown)
        {
            isHorizonMove = false;
            Debug.Log("vdown함수 안:" + isHorizonMove);
        }
        else if (hUp || vUp)
        {
            isHorizonMove = h != 0;
            Debug.Log("초기화후 horizontal" + isHorizonMove);

        }

        up_Down = false;
        down_Down = false;
        left_Down = false;
        right_Down = false;
        up_Up = false;
        down_Up = false;
        left_Up = false;
        right_Up = false;
        Debug.Log("움직이고난 후 down_Down:" + down_Down);

        /*
        if (vDown && v == 1)
            dirVec = Vector3.up;
        else if (vDown && v == -1)
            dirVec = Vector3.down;
        else if (hDown && h == -1)
            dirVec = Vector3.left;
        else if (hDown && h == 1)
            dirVec = Vector3.right;
    */

    }

    void FixedUpdate()
        {
            Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
            Debug.Log("moveVec:"+ moveVec);
            rigid.velocity = moveVec * Speed;
        }
        
        
    public void ButtonDown(string type)
    {
        switch (type)
        {
            case "U":
                Debug.Log("Push Up btn");
                up_Value = 1;
                up_Down = true;
                break;
            case "D":
                Debug.Log("Push down btn");
                down_Value = -1;
                down_Down = true;
                Debug.Log("down_Value:"+down_Value);
                break;
            case "L":
                left_Value = -1;
                left_Down = true;
                break;
            case "R":
                right_Value = 1;
                right_Down = true;
                break;
        }
    }
    
    public void ButtonUp(string type)
    {
        switch (type)
        {
            case "U":
                up_Value = 0;
                up_Up = false;
                break;
            case "D":
                down_Value = 0;
                down_Up = false;
                break;
            case "L":
                left_Value = 0;
                left_Up = false;
                break;
            case "R":
                right_Value = 0;
                right_Up = false;
                break;
        }
    }

       
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item") collision.gameObject.SetActive(false);
        if (collision.gameObject.tag == "Finish") 
        {
            success.SetActive(true);
            successimage.SetActive(true);
            btn1.SetActive(false);
            btn2.SetActive(false);
            btn3.SetActive(false);
            btn4.SetActive(false);
        }
    }
    

}
