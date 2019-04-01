using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeDelegation : MonoBehaviour {

    delegate void BossWork(string task);
    BossWork bossSandrasWork;

	// Use this for initialization
	void Start () {
        Debug.Log("Sandra is a very busy boss. Meanwhile, she says, her \"staff spend all day chatting and using Facebook.\"");

        Debug.Log("What are they chatting about?");

        Debug.Log("   ");
        bossSandrasWork = GeraldsTimeEnergy;
        bossSandrasWork("writing her proposals.");

        bossSandrasWork = SharmeensConstanstEfforts;
        bossSandrasWork("sheduling work for her 60 staff.");

        bossSandrasWork = MaureensEvenings;
        bossSandrasWork("ghost writing her emails.");
    }
	
    void GeraldsTimeEnergy(string task)
    {
        Debug.Log("\"Sandra drives me mental. All my time and energy is spent " + task + "\" grumbles Gerald to noone.");
    }

    protected void SharmeensConstanstEfforts(string task)
    {
        Debug.Log("\"Sandra is the worst,\" groans Sharmeen to her older colleague Maureen, \"I'm constantly " + task + "\"");
    }

    protected void MaureensEvenings(string task)
    {
        Debug.Log("\"Yeah.. One day you'll be 45, still " + task + "\" Maureen replies distantly.");
    }
}
