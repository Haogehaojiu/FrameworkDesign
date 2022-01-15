﻿using UnityEngine;

namespace FrameworkDesign.Example
{
    public class Enemy : MonoBehaviour, IController
    {
        private void OnMouseDown()
        {
            Destroy(gameObject);
            this.SendCommand<KillEnemyCommand>();
        }
        public IArchitecture GetArchitecture() => PointGame.Interface;
    }
}