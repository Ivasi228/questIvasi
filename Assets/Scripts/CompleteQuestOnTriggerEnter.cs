using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteQuestOnTriggerEnter : MonoBehaviour
{
    public Quests Quests;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Quests.CompleteCurrentQuest();
    }
}