using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;
    

    [SerializeField] float speed;

    float screen;

    private void Start()
    {
        screen = Screen.width;
    }

    private void Update()
    {
        player.transform.Translate(Vector3.forward * Time.deltaTime * 3);

        int i = 0;

        if(i < Input.touchCount)
        {
            
            
            if (Input.GetTouch(i).position.x > screen / 2)
            {
                
                player.transform.position += Vector3.right * speed * Time.deltaTime;
                
            }
            if (Input.GetTouch(i).position.x < screen / 2)
            {
                player.transform.position += Vector3.left * speed * Time.deltaTime;
                

            }
            ++i;
        }

    }


}
