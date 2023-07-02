using System.Numerics;

namespace Zoo {

    public class Animal {

        public string nickname;         // 昵称
        public string typeName;         // 动物名
        public int ageSeconds;          // 年龄(秒)
        public float happiness;         // 快乐
        public float happinessMax;      // 快乐上限
        public float energy;            // 饱食度
        public float energyMax;         // 饱食度上限
        public Vector2 position;        // x, y 坐标

        public Animal(string _nickname,
                      string _typeName,
                      int _ageSeconds,
                      float _happiness,
                      float _happinessMax,
                      float _energy,
                      float _energyMax,
                      Vector2 _position) {
            this.nickname = _nickname;
            this.typeName = _typeName;
            this.ageSeconds = _ageSeconds;
            this.happiness = _happiness;
            this.happinessMax = _happinessMax;
            this.energy = _energy;
            this.energyMax = _energyMax;
            this.position = _position;
        }

        // 年龄(月)
        public int GetAgeMonth() {
            return ageSeconds / 60 / 60 / 24 / 30;
        }

    }

}