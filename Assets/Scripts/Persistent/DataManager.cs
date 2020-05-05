using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

public class DataManager : MonoBehaviour
{
    // the number of save game slots
    public const int c_numSaveGameSlots = 5;

    // static reference to this instance
    public static DataManager m_instance;
    public static string m_sceneToLoad = "Intro";

    // the name of the game data file
    public string m_gameDataFileName;

    // the name of the save game file
    public string m_playerDataFileName;
/*
    // the loaded game data
    public GameData m_gameData;

    // the save game slots
    public PlayerData[] m_playerDataList;

    // the player data from the current save game slot
    public PlayerData m_playerData;
*/
    // the active save game slot number
    public int m_activeSaveGameSlotNumber;

    // set this to switch to a different save game slot
    int m_targetSaveGameSlotNumber;

    // unity awake
    void Awake()
    {
        // remember this instance to this
        m_instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
