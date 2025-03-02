using UnityEngine;

public abstract class Singleton<T> : NewMonoBehaviour where T : NewMonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError(typeof(T) + "is nothing");
            }
            return _instance;
        }
    }

    protected override void Awake()
    {
        base.Awake();
        if (this != Instance)
        {
            Destroy(this);
            return;
        }
    }
}
