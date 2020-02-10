﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    public class EffectObject : MonoBehaviour
    {

        public float duration = 0f;

        private void Awake() => Destroy(gameObject, duration);

    }

}
