using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    public float moveSpeed = 0.6f;
    // Start is called before the first frame update
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        if(h == 0)
        {
            // 이동을 안하는 경우
            GetComponent<Animator>().SetBool("isRun", false);
        }
        else if(h > 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            // 이동을 하는 경우
            
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
            Move(h);
        }

    }
    private void Move(float h)
    {
        Vector3 pos = new Vector3();
        GetComponent<Animator>().SetBool("isRun", true);
        pos.x = h * moveSpeed * Time.deltaTime;
        transform.Translate(pos);
    }
}

    // Update is called once per frame