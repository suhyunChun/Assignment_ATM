using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DepositEventController : MonoBehaviour
{

    [SerializeField] private TMP_InputField usrTxt;
    [SerializeField] private TextMeshProUGUI cash;
    [SerializeField] private TextMeshProUGUI balance;
    public GameObject panel;
    // Start is called before the first frame update

    
    //private int currCash;
    //private int currBalance;

    private void Start()
    {
        cash.text = GameManager.I.userData.cash.ToString();
        balance.text = GameManager.I.userData.balance.ToString();
    }

    public void DepositWithUsrTxt()
    {
//        currCash = int.Parse(cash.text);
//        currBalance = int.Parse(balance.text);
        if (GameManager.I.userData.cash - int.Parse(usrTxt.text) >= 0)
        {
            GameManager.I.userData.balance += int.Parse(usrTxt.text);
            GameManager.I.userData.cash -= int.Parse(usrTxt.text);
            balance.text = GameManager.I.userData.balance.ToString();
            cash.text = GameManager.I.userData.cash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
        usrTxt.text = "";

    }

    public void DepositWithBtn(int number) {
 //       currCash = int.Parse(cash.text);
 //       currBalance = int.Parse(balance.text);
        if (GameManager.I.userData.cash - number >= 0)
        {
            GameManager.I.userData.balance += number;
            GameManager.I.userData.cash -= number;
            balance.text = GameManager.I.userData.balance.ToString();
            cash.text = GameManager.I.userData.cash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }

    }


}
