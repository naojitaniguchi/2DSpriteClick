using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float walkSpeed = 3.0f;
    bool hasAnimation = false;
    // Start is called before the first frame update
    void Start()
    {
        if ( gameObject.GetComponent<Animator>() != null)
        {
            hasAnimation = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.left * walkSpeed;
            if (gameObject.transform.localScale.x >= 0.0f)
            {
                gameObject.transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            }
            setAnim("Run");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * walkSpeed;
            if (gameObject.transform.localScale.x <= 0.0f)
            {
                gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            setAnim("Run");
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * walkSpeed;
            setAnim("Run");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.down * walkSpeed;
            setAnim("Run");
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            setAnim("Idle");
        }
    }

    void setAnim(string animName )
    {
        if (hasAnimation)
        {
            gameObject.GetComponent<Animator>().SetTrigger(animName);
        }
    }
}
