
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]

public class PlayerPrefDeleter : MonoBehaviour
{
    [MenuItem("Tools/PlayerPrefbs remover")]

   public static void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("playerPrefs deleteados");
    }
   
}
