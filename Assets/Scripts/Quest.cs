using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Quest : MonoBehaviour
{
    [SerializeField] public string Description;
    [SerializeField] public int NextQuest;
    [SerializeField] public bool Active;
    [NonSerialized]public Quests Quests;

    public Quest Complete()
    {
        Quests.QuestsDescriptions.Remove(this);
        Active = false;
        return Quests.QuestsDescriptions[NextQuest];
    }
}
