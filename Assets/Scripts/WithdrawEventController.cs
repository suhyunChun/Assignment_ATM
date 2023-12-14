using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WithdrawEventController : MonoBehaviour
{
    [SerializeField] private TMP_InputField usrTxt;
    [SerializeField] private TMP_Text cash;
    [SerializeField] private TMP_Text balance;
    public GameObject panel;
    // Start is called before the first frame update

//    private int currCash;
//    private int currBalance;

    private void Start()
    {
        cash.text = GameManager.I.userData.cash.ToString();
        balance.text = GameManager.I.userData.balance.ToString();
    }

    public void WithdrawWithUsrTxt()
    {
     //   currCash = int.Parse(cash.text);
     //   currBalance = int.Parse(balance.text);
        if (GameManager.I.userData.balance - int.Parse(usrTxt.text) >= 0)
        {
            GameManager.I.userData.cash += int.Parse(usrTxt.text);
            GameManager.I.userData.balance -= int.Parse(usrTxt.text);
            balance.text = GameManager.I.userData.balance.ToString();
            cash.text = GameManager.I.userData.cash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
        usrTxt.text = "";

    }

    public void WithdrawWithBtn(int number)
    {
      //  currCash = int.Parse(cash.text);
      //  currBalance = int.Parse(balance.text);
        if (GameManager.I.userData.balance - number >= 0)
        {
            GameManager.I.userData.cash += number;
            GameManager.I.userData.balance -= number;
            balance.text = GameManager.I.userData.balance.ToString();
            cash.text = GameManager.I.userData.cash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }

    }
}
