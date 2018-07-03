using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float movingD = 6; //До какого рассстояния дойдет объект
    public float speed = 100; //Скорость объекта
    public float rotationSpeed = 100; //Скорость вращения объекта
    bool RandomSpeed;
    public float maxSpeed = 16;

    // Выполняем один раз
	void Start ()
    {
        if (RandomSpeed)
        {
            speed = Random.Range(1, 16);
        }
	}
	
	// Обновление каждый кадр
	void Update () {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        //Если положение объекта больше равен Moving поворачиваем
        if (transform.position.x >= movingD || transform.position.x <= -movingD){
            speed = -speed;
        }
    }
}
