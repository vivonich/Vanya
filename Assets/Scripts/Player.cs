using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 6; //Скорость игрока
    public float JumpSpeed = 100; //Скорость прыжка
    public float roationSpeed = 100; 

    void Move() {
        float moveVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveHorizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveUp = 0;

        float rotationHorizontal = Input.GetAxis("Horizontal") * roationSpeed * Time.deltaTime;
        if (Input.GetButtonDown("Jump"))
        {
            moveUp = JumpSpeed * Time.deltaTime; 
        }

        transform.Rotate(0, rotationHorizontal, 0);
        transform.Translate(moveHorizontal, moveUp, moveVertical);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        
        
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Движение игрока
        Move();
		
	}
}
