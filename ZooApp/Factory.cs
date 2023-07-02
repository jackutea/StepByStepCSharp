using System.Numerics;

namespace Zoo {

    public static class Factory {

        public static Animal SpawnPig(string nickname) {
            Animal pig = new Animal(
                nickname,
                "猪",
                0,
                100,
                100,
                100,
                100,
                new Vector2(0, 0)
            );
            return pig;
        }

        public static Animal Cow(string nickname) {
            Animal cow = new Animal(
                nickname,
                "牛",
                0,
                100,
                100,
                100,
                100,
                new Vector2(0, 0)
            );
            return cow;
        }

        public static Animal Sheep(string nickname) {
            Animal sheep = new Animal(
                nickname,
                "羊",
                0,
                100,
                100,
                100,
                100,
                new Vector2(0, 0)
            );
            return sheep;
        }

        public static Animal Chicken(string nickname) {
            Animal chicken = new Animal(
                nickname,
                "鸡",
                0,
                100,
                100,
                100,
                100,
                new Vector2(0, 0)
            );
            return chicken;
        }

    }
}