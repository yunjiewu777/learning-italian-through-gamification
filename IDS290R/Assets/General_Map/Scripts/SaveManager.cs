using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : MonoBehaviour
{

    public Level level;
    public Task minigameA;
    public Task minigameM;
    public Task minigameT;

    private static SaveManager instance;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Save();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
    }
    private void Awake()
    {
        if (instance != null)
            Debug.LogWarning("Found more than one Save Manager in the scene");
        instance = this;
    }

    public static SaveManager GetInstance()
    {
        return instance;
    }

    public void Save()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();
            Debug.Log(Application.persistentDataPath);
            FileStream file = File.Open(Application.persistentDataPath + "/" + "SaveTest.dat", FileMode.OpenOrCreate);

            Save data = new Save();
            SavePlayer(data);

            bf.Serialize(file, data);
            file.Close();


        }
        catch (System.Exception)
        {

        }

    }


    public void Load()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();
            Debug.Log(Application.persistentDataPath);
            FileStream file = File.Open(Application.persistentDataPath + "/" + "SaveTest.dat", FileMode.Open);

            Save data = (Save)bf.Deserialize(file);
            file.Close();

            LoadPlayer(data);

        }
        catch (System.Exception)
        {

        }

    }

    private void LoadPlayer(Save data)
    {
        level.difficultyLevel = data.MyPlayerData.MyLevel;
        minigameA.score = data.MyPlayerData.GameA;
        minigameM.score = data.MyPlayerData.GameM;
        minigameT.score = data.MyPlayerData.GameT;

    }

    private void SavePlayer(Save data)
    {
        data.MyPlayerData = new PlayerData(level, minigameA, minigameM, minigameT);

    }

}
