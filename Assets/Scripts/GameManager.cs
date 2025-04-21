using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;

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



}
