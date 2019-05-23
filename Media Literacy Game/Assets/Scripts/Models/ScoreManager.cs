using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Models
{
    class ScoreManager
    {
        public int latestScore { get; set; }
        Scene scene { get; set; }

        public ScoreManager(Scene scene)
        {
            this.scene = scene;
        }
    }
}