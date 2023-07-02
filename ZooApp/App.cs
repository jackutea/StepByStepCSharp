using System;
using System.Threading;
using System.Collections.Generic;

namespace Zoo {

    public class App {

        static void Main() {

            Console.WriteLine("==== 动物园 ====");
            Console.WriteLine();

            // 1. 初始化游戏
            Balance balance = new Balance();
            balance.gold = 1000;

            List<Animal> animals = new List<Animal>();
            Animal pig = Factory.SpawnPig("Jack");
            animals.Add(pig);

            // 2. 游戏循环
            while (true) {

                // 2.1 显示游戏状态
                GameStatus(balance, animals);

                Console.WriteLine("请输入操作编号:");
                Console.WriteLine("1. 购买动物");
                Console.WriteLine("2. 喂养动物");
                Console.WriteLine("3. 退出游戏");

                // - 等待用户输入
                // string input = Console.ReadLine();

                // - 根据用户输入执行操作

                // - 运营消耗
                balance.gold -= 1;

                Thread.Sleep(100);

            }

        }

        static void GameStatus(Balance balance, List<Animal> animals) {
            // 2.1 显示游戏状态
            Console.WriteLine("-- 游戏状态 --");
            Console.WriteLine("金币: " + balance.gold);
            Console.WriteLine("动物数: " + animals.Count);
            foreach (Animal animal in animals) {
                Console.WriteLine(animal.nickname + " [" + animal.typeName + "] " + animal.GetAgeMonth() + "月");
            }
        }

    }

}