using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiScoreSpawner : MonoBehaviour
{
    public Text Id;
    public Text Name;
    public Text Result;
    public void createItem(int id, string name, float result)
    {
        Id.text = id.ToString();
        Name.text = name;
        Result.text = result.ToString();
    }
}
