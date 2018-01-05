﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusIndicator : MonoBehaviour {

    [SerializeField]
    private RectTransform healthBarRect;
    [SerializeField]
    private Text healthText;

    private void Awake()
    {
        if (healthBarRect == null)
        {
            Debug.LogError(" STATUS INDICATOR: No health bar object referenced.");
        }
        if (healthBarRect == null)
        {
            Debug.LogError("STATUS INDICATOR: No health text bar object referenced.");
        }
    }

    public void SetHealth(int _cur, int _max)
    {
        float _value = (float) _cur / _max;
        healthBarRect.localScale = new Vector3(_value, healthBarRect.localScale.y, healthBarRect.localScale.z);
        healthText.text = _cur + "/" + _max + " HP";
    }




}
