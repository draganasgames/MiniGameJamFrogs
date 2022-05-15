using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;

public class HiScoreHandler : MonoBehaviour
{
    public string StringPath="jsonTestFile";
    public static HiScoreHandler Instance;
    private void Awake()
    {
        StringPath = Application.streamingAssetsPath+"/" + StringPath;
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        ReadString();
    }
    public Dictionary<int, HiScore> HighScorePairs= new Dictionary<int, HiScore>();
    public int id;
    public void addToDictionary(HiScore hiScore)
    {
        HighScorePairs.Add(id, hiScore);
        id++;
    }
    public void addToDictionary(List<HiScore> hiScores)
    {
        if (hiScores == null || hiScores.Count == 0) return;
        foreach (var item in hiScores)
        {
            HighScorePairs.Add(id, item);
            id++;
        }
    }
    public HiScore[] getHighScoreList() => HighScorePairs.Values.OrderByDescending(hs => hs.Result).ToArray();

    void ReadString()
    {
        StreamReader reader = new StreamReader(StringPath);
        string jsonFile=reader.ReadToEnd();
        reader.Close();
        reader.Dispose();
        addToDictionary(HiScore.CreateFromJSON(jsonFile));
    }

    void WriteString(string jsonString)
    {
        StreamWriter writer = new StreamWriter(StringPath, false);
        writer.WriteLine(jsonString);
        writer.Dispose();
        writer.Close();
    }
    private void OnDisable()
    {
        WriteString(HiScore.CreateJSON(HighScorePairs.Values.ToList()));
    }
}
