using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        //G 随机得到一个物品放到背包里面
        if (Input.GetKeyDown(KeyCode.G))
        {
            int id = Random.Range(1, 18);
            Knapsack.Instance.StoreItem(id);
        }
    }
}
