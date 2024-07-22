using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temtem : MonoBehaviour
{
    [SerializeField] string _name = "Name";
    [SerializeField] Sprite _sprite;
    [SerializeField] int _level = 0;
    [SerializeField] int _lifeMax = 0;
    [SerializeField] int _lifeCurrent = 0;
    [SerializeField] int _manaMax = 0;
    [SerializeField] int _manaCurrent = 0;
    [SerializeField] int[] _stats = new int[7];
    [SerializeField] string[] _skills = new string[4];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    #region Getters

    public string GetName()
    {
        return _name;
    }

    public Sprite GetSprite()
    {
        return _sprite;
    }

    public int GetLevel()
    {
        return _level;
    }

    public int GetLifeMax()
    {
        return _lifeMax;
    }

    public int GetLifeCurrent()
    {
        return _lifeCurrent;
    }

    public int GetManaMax()
    {
        return _manaMax;
    }

    public int GetManaCurrent()
    {
        return _manaCurrent;
    }

    public int[] GetStats()
    {
        return _stats;
    }

    public string[] GetSkills()
    {
        return _skills;
    }

    #endregion

    #region Setters

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetSprite(Sprite sprite)
    {
        _sprite = sprite;
    }

    public void SetLevel(int level)
    {
        _level = level;
    }

    public void SetLifeMax(int lifeMax)
    {
        _lifeMax = lifeMax;
    }

    public void SetLifeCurrent(int lifecurrent)
    {
        _lifeCurrent = lifecurrent;
    }

    public void SetManaMax(int manamax)
    {
        _manaMax = manamax;
    }

    public void SetManaCurrent(int manacurrent)
    {
        _manaCurrent = manacurrent;
    }

    public void SetStats(int[] stats)
    {
        _stats = stats;
    } 

    public void SetSkills(string[] skills)
    {
        _skills = skills;
    }

    #endregion
}
