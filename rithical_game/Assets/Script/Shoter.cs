using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoter : MonoBehaviour
{
    public Texture cursor;
    void Update()
    {
        GameObject ini_ball;
        if (Input.GetMouseButtonDown(0))
        {
            GameObject prefab = null;
            Vector3 create_shouter_vec = new Vector3(
                    0.0f,
                    -4.0f,
                    0.0f
                );
            //ファイル参照の時のコード
            prefab = (GameObject)Resources.Load("Objects/Ball");
            if (prefab != null)
            {
                ini_ball = (GameObject)GameObject.Instantiate(prefab, 
                    create_shouter_vec, Quaternion.identity);
               
                Vector3 cursorpoint = GameObject.Find("GameCursor").transform.position;
                float dy = cursorpoint.y - create_shouter_vec.y;
                float dx = cursorpoint.x - create_shouter_vec.x;
                float rad = Mathf.Atan2(dy, dx);

                Vector3 ball_speed = new Vector3(40.0f*Mathf.Cos(rad), 40.0f*Mathf.Sin(rad), 0.0f);
                ini_ball.GetComponent<Rigidbody>().velocity = ball_speed;
            }
          
        }
    }
}
