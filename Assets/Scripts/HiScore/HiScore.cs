using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiScore
{
    public string Name;
    public float Result;

    public HiScore(string name, float result)
    {
        Name = name;
        Result = result;
    }
    public override string ToString()
    {
        return string.Format("{0}: {1}", Name, Result);
    }

    public static List<HiScore> CreateFromJSON(string jsonString)
    {
        return JsonConvert.DeserializeObject<List<HiScore>>(jsonString);
    }

    public static string CreateJSON(List<HiScore> scores)
    {
        return JsonConvert.SerializeObject(scores);
    }
}
