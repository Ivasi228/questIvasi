using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quests : MonoBehaviour
{
    [SerializeField] private List<Quest> _questsDescriptions = new List<Quest>();
    public List<Quest> QuestsDescriptions {
        get
        {
            UpdateText();
            return _questsDescriptions;
        }
        set
        {
            _questsDescriptions = value;
            UpdateText();
        }
    }
    private Quest _currentQuest;

    public TMP_Text Text;

    private void Start()
    {
        _currentQuest = QuestsDescriptions[0];
        foreach (Quest quest in _questsDescriptions)
        {
            quest.Quests = this;
        }
    }
    public void CompleteCurrentQuest()
    {
        if (_currentQuest != null)
        {
            _currentQuest = _currentQuest.Complete();
        }
    }

    public void UpdateText()
    {
        Text.text = "";
        Text.text += _questsDescriptions[0].Description + "\n";
    }

}
