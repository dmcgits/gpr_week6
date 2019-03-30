using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeDelegation : MonoBehaviour {

    delegate void BossSandrasCreditedWork(string task);
    BossSandrasCreditedWork sandrasCreditedWork;

	// Use this for initialization
	void Start () {
        Debug.Log("Sandra is a very busy boss. Meanwhile, she says, her \"staff spend all day chatting and using Facebook.\"");

        Debug.Log("What are they chatting about?");

        Debug.Log("   ");
        sandrasCreditedWork = GeraldsTimeEnergy;
        sandrasCreditedWork("writing her proposals.");

        sandrasCreditedWork = SharmeensConstanstEfforts;
        sandrasCreditedWork("sheduling work for her 60 staff.");

        sandrasCreditedWork = LayleysEvenings;
        sandrasCreditedWork("signing off expenditures from her 35 managers.");
    }
	
    void GeraldsTimeEnergy(string task)
    {
        Debug.Log("\"Sandra drives me mental. All my time and energy is spent " + task + "\" grumbles Gerald to noone.");
    }

    protected void SharmeensConstanstEfforts(string task)
    {
        Debug.Log("\"Sandra is the worst,\" groans Sharmeen to her older colleague Layley, \"I'm constantly " + task + "\"");
    }

    protected void LayleysEvenings(string task)
    {
        Debug.Log("\"Get used to it babe, I'd have a degree and a real job somewhere if I hadn't spent my evenings " + task + "\" Layley reminds Sharmeen.");
    }
}
