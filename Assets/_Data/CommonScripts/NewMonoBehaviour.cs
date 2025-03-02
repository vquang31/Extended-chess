﻿using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviour : MonoBehaviour
{
    protected virtual void Awake()
    {
        this.LoadComponents();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected virtual void Reset()
    {
        this.LoadComponents();
        this.ResetValues();
    }

    // sử dụng khi awake hoặc reset
    // load các component cần thiết
    protected virtual void LoadComponents()
    {

    }

    protected virtual void ResetValues()
    {

    }

}
