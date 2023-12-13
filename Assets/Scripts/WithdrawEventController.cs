using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WithdrawEventController : MonoBehaviour
{
    [SerializeField] private TMP_InputField usrTxt;
    [SerializeField] private TextMeshProUGUI cash;
    [SerializeField] private TextMeshProUGUI balance;
    public GameObject panel;
    // Start is called before the first frame update

    private int currCash;
    private int currBalance;


    private void Start()
    {
        currCash = int.Parse(cash.text);
        currBalance = int.Parse(balance.text);
    }
    public void WithdrawWithUsrTxt()
    {
        if (currBalance - int.Parse(usrTxt.text) >= 0)
        {
            currCash += int.Parse(usrTxt.text);
            currBalance -= int.Parse(usrTxt.text);
            balance.text = currBalance.ToString();
            cash.text = currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }

    }

    public void WithdrawWithBtn(int number)
    {
        if (currBalance - number >= 0)
        {
            currCash += number;
            currBalance -= number;
            balance.text = currBalance.ToString();
            cash.text = currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }

    }
}
