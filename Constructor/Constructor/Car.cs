


using System.Windows.Forms;

namespace YZL5155_Constructor
{
    class Car
    {
        
        public string Brand { get; set; }
        public string EnginSize { get; set; }
        public string Model { get; set; }

        //Constructors are executed automaticly when a class object is created. They are always named after classes and a class can have multiple overloaded constructors.
        public Car()
        {
            // Here a constructor without any  parameter. This constructor will be initialized when this " Car car_1 = new Car(); " run.

            MessageBox.Show("Car object is created without any parameter.");
        }



        // Overloading constructors..
        // Calling this constructor depends on the way we create the object, for example " Car car_2 = new Car("Volvo"); "  
        // The other functionality of constructor is we can assign a value to a variable quickly.

        public Car(string marka)
        {
            //"this" means it's relevant class. We can reach objects of this class.
            this.Brand = marka;
           
            MessageBox.Show($"Brand: {this.Brand}");
        }

        // Another overloaded constructor. It gives us another option when we create object.
        public Car(string marka, string model)
        {
            this.Brand = marka;
            this.Model = model;

            MessageBox.Show($"Brand: {this.Brand}\nModel: {this.Model}");
        }

        
        public Car(string marka, string model, string motorHacmi)
        {
            this.Brand = marka;
            this.Model = model;
            this.EnginSize = motorHacmi;

            MessageBox.Show($"Brand: {this.Brand}\nModel: {this.Model}\nEngin Size: {this.EnginSize}");
        }
    }
}
