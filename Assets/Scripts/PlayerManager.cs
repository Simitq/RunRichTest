using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public TMP_Text moneyText;
    int moneyCount = 40;
    public PickUpUI pickUpUI;
    public PickUpUI pickUpUIBottle;
    public GameObject particalSysBills1;
    public GameObject particalSysBills2;
    public GameObject particalSysBottle1;
    public GameObject particalSysBottle2;
    public Transform partSysPos;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bills")
        {
            pickUpUI.PickUp();
            Instantiate(particalSysBills1, partSysPos.position, Quaternion.identity);
            Instantiate(particalSysBills2, partSysPos.position, Quaternion.identity);
            moneyCount++;
            moneyText.text = moneyCount.ToString();
            Destroy(other.gameObject);
            
        }
        if(other.gameObject.tag == "Bottle")
        {
            pickUpUIBottle.PickUpBottle();
            Instantiate(particalSysBottle1, partSysPos.position, Quaternion.identity);
            Instantiate(particalSysBottle2, partSysPos.position, Quaternion.identity);
            moneyCount -= 20;
            moneyText.text = moneyCount.ToString();
            Destroy(other.gameObject);
            
        }
    }

    

    
}
