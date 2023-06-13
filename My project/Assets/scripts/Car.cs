using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Car : MonoBehaviour
{
   //object value = Debug.Log("Сообщение для отладки");
    //public floate speed;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Ты убит");
            SceneManager.LoadScene(1);
        }


    }

}
