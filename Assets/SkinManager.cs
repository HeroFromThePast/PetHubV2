using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.UI;

public class SkinManager : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;
    public GameObject Info, ButtonMenu;
    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");
        characterList = new GameObject[transform.childCount];
        // > <
        for (int i = 0; i < transform.childCount; i++)
            characterList[i] = transform.GetChild(i).gameObject;


        foreach (GameObject go in characterList)
            go.SetActive(false);

        if (characterList[index])
            characterList[index].SetActive(true);
    }

    public void ToggleLeft()
    {
        characterList[index].SetActive(false);


        index--;
        if (index < 0)
            index = characterList.Length - 1;
       
        characterList[index].SetActive(true);
    }

    public void ToggleRight()
    {
        characterList[index].SetActive(false);


        index++;
        if (index == characterList.Length)
            index = 0;

        characterList[index].SetActive(true);
    }

    public void SaveSelection()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);

        Time.timeScale = 1f;
        Info.SetActive(false);
        ButtonMenu.SetActive(true);
    }



}
