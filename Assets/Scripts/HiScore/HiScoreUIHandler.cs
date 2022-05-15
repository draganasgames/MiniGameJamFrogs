using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiScoreUIHandler : MonoBehaviour
{
    public List<HiScoreSpawner> hiScoreSpawners = new List<HiScoreSpawner>();
    public HiScoreSpawner PrefabSpawner;
    public ScrollRect ScrollRect;
    int id=0;
    public void createList()
    {
        var items=HiScoreHandler.Instance.getHighScoreList();
        foreach (var item in items)
        {
            id++;
            var hiScoreUi=Instantiate(PrefabSpawner, ScrollRect.content);
            hiScoreUi.createItem(id, item.Name, item.Result);
            hiScoreSpawners.Add(hiScoreUi);
        }
        
    }

    public void destroyList()
    {
        while (hiScoreSpawners.Count>0)
        {
            var hiScore = hiScoreSpawners[0];
            hiScoreSpawners.RemoveAt(0);
            Destroy(hiScore);
        }
    }
}
