using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class UiSquad : MonoBehaviour
{
    [SerializeField] private GameObject _uiOverworld;
    [SerializeField] private GameObject _uiSquad;
    [SerializeField] private GameObject _uiStats;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private int _idTemtem;
    
    private bool _statsIsOpen;
    private bool _squadIsOpen = false;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (_squadIsOpen == true)
        {
            _uiOverworld.SetActive(false);
            _uiSquad.SetActive(true);
        }
        else if (_squadIsOpen == false)
        {
            _uiOverworld.SetActive(true);
            _uiSquad.SetActive(false);
        }

        
        if (_statsIsOpen == true)
        {
            _uiSquad.SetActive(false);
            _uiStats.SetActive(true);
        }
        else if (_statsIsOpen == false)
        {
            _uiStats.SetActive(false);
        }



    }

    private void OnEnable()
    {
        for (int i = 0; i < _gameManager.GetTemtemSquad().Length; i = i +1)
        {
            if (_gameManager.GetTemtemSquad()[i] != null)
            {
                _uiSquad.transform.GetChild(i).gameObject.SetActive(true);

                #region StatsSquad
                _uiSquad.transform.GetChild(i).transform.GetChild(4).GetComponent<Image>().sprite = _gameManager.GetTemtemSquad()[i].GetSprite();
                _uiSquad.transform.GetChild(i).transform.GetChild(3).GetComponent<Text>().text = _gameManager.GetTemtemSquad()[i].GetName();
                _uiSquad.transform.GetChild(i).transform.GetChild(5).GetComponent<Text>().text = "Niv." + _gameManager.GetTemtemSquad()[i].GetLevel();
                _uiSquad.transform.GetChild(i).transform.GetChild(6).GetComponent<Text>().text = _gameManager.GetTemtemSquad()[i].GetLifeCurrent().ToString() + "/" + _gameManager.GetTemtemSquad()[i].GetLifeMax().ToString();
                _uiSquad.transform.GetChild(i).transform.GetChild(7).GetComponent<Text>().text = _gameManager.GetTemtemSquad()[i].GetManaCurrent().ToString() + "/" + _gameManager.GetTemtemSquad()[i].GetManaMax().ToString();
                #endregion

                _uiStats.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = _gameManager.GetTemtemSquad()[_idTemtem].GetStats()[0].ToString();
                _uiStats.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = _gameManager.GetTemtemSquad()[_idTemtem].GetStats()[1].ToString();
                _uiStats.transform.GetChild(2).transform.GetChild(0).transform.GetChild(4).transform.GetChild(0).GetComponent<Text>().text = _gameManager.GetTemtemSquad()[_idTemtem].GetStats()[2].ToString();
                _uiStats.transform.GetChild(2).transform.GetChild(0).transform.GetChild(5).transform.GetChild(0).GetComponent<Text>().text = _gameManager.GetTemtemSquad()[_idTemtem].GetStats()[3].ToString();
                _uiStats.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Text>().text = _gameManager.GetTemtemSquad()[_idTemtem].GetStats()[4].ToString();
                _uiStats.transform.GetChild(2).transform.GetChild(0).transform.GetChild(7).transform.GetChild(0).GetComponent<Text>().text = _gameManager.GetTemtemSquad()[_idTemtem].GetStats()[5].ToString();
                _uiStats.transform.GetChild(2).transform.GetChild(0).transform.GetChild(8).transform.GetChild(0).GetComponent<Text>().text = _gameManager.GetTemtemSquad()[_idTemtem].GetStats()[6].ToString();
                _uiStats.transform.GetChild(2).transform.GetChild(5).GetComponent<Image>().sprite = _gameManager.GetTemtemSquad()[_idTemtem].GetSprite();
                _uiStats.transform.GetChild(2).transform.GetChild(4).GetComponent<Text>().text = _gameManager.GetTemtemSquad()[_idTemtem].GetName();

            }
            else
            {
                _uiSquad.transform.GetChild(i).gameObject.SetActive(false);
            }
            
        }
    }


    //Au lieu de faire plusieurs fonctions fait en une seule et fait un ID différent pour chaque Temtem

    public void StatsOpen(int IDTemtem)
    {
        _statsIsOpen = true;
        _idTemtem = IDTemtem;
    }
    public void StatsClose()
    {
        _statsIsOpen = false;
    }

    //Squad

    public void SquadOpen()
    {
        _squadIsOpen = true;
    }
    public void SquadClose()
    {
        _squadIsOpen = false;
    }

}
