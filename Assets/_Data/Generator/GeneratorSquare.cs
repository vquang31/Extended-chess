using UnityEngine;

public class GeneratorSquare : Generator
{
    // White
    private GameObject _squarePrefab1;
    // Black
    private GameObject _squarePrefab2;

    protected override void Awake()
    {
        base.Awake();
        this.LoadComponents();
    }


    protected override void LoadComponents()
    {
        this._squarePrefab1 = Resources.Load<GameObject>("Prefabs_Square1");
        this._squarePrefab2 = Resources.Load<GameObject>("Prefabs_Square2");
    }


    protected override void Generate()
    {
        base.Generate();
        // Generate square

    }
}