using System;

namespace project {
    abstract class Robot: IRun, IJump {

        private static int count; // Статическое поле
        private string name = string.Empty; // Инициализация значением по умолчанию
        private int weight;

        protected string surnaaame=string.Empty; // Доступно в классах наследниках
        private byte[] coordinates = new byte[3]; // Инициализация массивом по умолчанию
        public string Name {
            get {
                // Console.Write("Getting name: ");
                return this.name;
            }
            private set {
                
            }
        }
        public int Weight {
            get {
                Console.Write("Getting weight: ");
                return this.weight;
            }
            set {
                if (value < 1) {
                    this.weight = 1;
                   
                }
                 else if (value > 5000) {
                        this.weight = 5000;
                    }
                else {
                    this.weight = value;
                }
            }
        }

public byte[] Coordinates {
            get {
                return this.coordinates;
            }
            private set {
               
            }
        }

        public int Width { get; set; } // Автоматическое свойство 
        public float speed { get; set;}
        public float y { get; set;}

        public Robot(string name, int weight, byte[] coordinates) {
            Console.WriteLine("Robot created");
            this.SetValues(name, weight, coordinates);
            count++;
            
        }

        public Robot() {
           count++;
        }

          public Robot(string name) {
            Console.WriteLine("Robot created");
            this.name = name;
            count++;
        }

        public void SetValues(string name, int weight, byte[] coordinates) {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public void SetValues(string name, int weight) {
            this.name = name;
            this.weight = weight;
        }

        public void SetValues(string name) {
            this.name = name;
        }

      

        public abstract void printValues();

        public static void Print() {
            Console.WriteLine("Count: " + count);
        }

        public void RobotRun()
        {
            Console.WriteLine("Robot is running");
        }

        public void Jump()
        {
            Console.WriteLine("Robot is jumping");
        }
    }
}
