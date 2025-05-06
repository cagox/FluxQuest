using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;
    public bool ProductionMode; // Determines if save files are JSON or Binary.

    public static GameManager Instance
    {
        get
        {
            if (_instance == null) {
                Debug.LogError("ERROR: No GameManager exists in this scene.");
            }
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null){
            DontDestroyOnLoad(gameObject);
            _instance = this;
        } else if (_instance != this){
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Debug.Log(Application.persistentDataPath);
    }


}
