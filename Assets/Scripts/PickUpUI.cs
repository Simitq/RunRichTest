using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickUpUI : MonoBehaviour
{
    Animator pickupAnimator;
    
    TMP_Text pickUpMoneyCountInRow;
    int countInRow;

    private void Start()
    {
        pickupAnimator = GetComponent<Animator>();
        pickUpMoneyCountInRow = GetComponentInChildren<TMP_Text>();
    }

    

    public void PickUp()
    {
        countInRow++;
        pickUpMoneyCountInRow.text = countInRow.ToString();
        if (pickupAnimator.GetBool("isActive"))
        {
            pickupAnimator.SetTrigger("PickUp");
            
        }
        pickupAnimator.SetBool("isActive", true);
    }

    public void PickUpBreak()
    {
        pickupAnimator.SetBool("isActive", false);
        countInRow = 0;
    }

    public void PickUpBottle()
    {
        pickupAnimator.SetBool("PickBottle", true);
    }
    public void PickUpBottleBreak()
    {
        pickupAnimator.SetBool("PickBottle", false);
    }


}
