using UnityEngine;

public class BOB_Blackboard : MonoBehaviour {

    public int moneyInPocket;
    public int moneyInAccount;
    public int withdrawalAmmount;
    public int salary;
    public int priceOfBeer;
    public float thirstReductionPerBeer = 75f;
    public float thirst;
    public float thirstIncrementPerSecond = 1;
    public float thirstThreshold = 100;
    public int flowers = 0;
    public int numBoxesMax;
    public int numBoxesTransported;

    private TextMesh pocketLine;
    private TextMesh accountLine;
    private TextMesh thirstLine;
    private TextMesh flowersLine;

    // Use this for initialization
    void Start () {
        pocketLine = GameObject.Find("PocketLine").GetComponent<TextMesh>();
        if (pocketLine != null) pocketLine.text = "Pocket: " + moneyInPocket;

        accountLine = GameObject.Find("AccountLine").GetComponent<TextMesh>();
        if (accountLine != null) accountLine.text = "Account: " + moneyInAccount;

        thirstLine = GameObject.Find("ThirstLine").GetComponent<TextMesh>();
        if (thirstLine != null) thirstLine.text = "Thirst: " + Mathf.RoundToInt(thirst);

        flowersLine = GameObject.Find("FlowersLine").GetComponent<TextMesh>();
        if (flowersLine != null) flowersLine.text = "Flowers: " + flowers;
    }
	
	// Update is called once per frame
	void Update () {
        thirst += thirstIncrementPerSecond * Time.deltaTime;
        if (thirstLine != null) thirstLine.text = "Thirst: " + Mathf.RoundToInt(thirst);
    }


    public bool VeryThirsty ()
    {
        return thirst >= thirstThreshold || thirst<0.0f;
    }

    public bool HasMoneyToBuyBeer ()
    {
        return moneyInPocket >= priceOfBeer;
    }
    public bool HasMoneyToGoBanck()
    {
        return moneyInAccount >= withdrawalAmmount;
    }
    public bool BuyBeer()
    {
        if (!HasMoneyToBuyBeer())
            return false;
        else
        {
            moneyInPocket -= priceOfBeer;
            if (pocketLine != null) pocketLine.text = "Pocket: " + moneyInPocket;
            return true;
        }
    }

    public void DrinkBeer()
    {
        thirst -= thirstReductionPerBeer;
        if (thirstLine != null) thirstLine.text = "Thirst: " + Mathf.RoundToInt(thirst);
    }

    public void GetPaid () {
        moneyInAccount += salary;
        if (accountLine != null) accountLine.text = "Account: " + moneyInAccount;
    }

    public bool MakeWithdrawal ()
    {
        //10>=10
        if (moneyInAccount >= withdrawalAmmount)
        {
            moneyInAccount -= withdrawalAmmount;
            moneyInPocket += withdrawalAmmount;
            if (pocketLine != null) pocketLine.text = "Pocket: " + moneyInPocket;
            if (accountLine != null) accountLine.text = "Account: " + moneyInAccount;
            return true;
        }
        else return false;
    }

    public bool IncrementFlowers ()
    {
        flowers++;
        if (flowersLine != null) flowersLine.text = "Flowers: " + flowers;
        return true;
    }
    public bool IncrementNumBoxes()
    {
        numBoxesTransported++;
       // if (flowersLine != null) flowersLine.text = "Flowers: " + flowers;
        return true;
    }
}
