using System.Collections.Generic;


public static class Programm {
    public static void main(String[] args) { 
        
    }   
}


// класс станции содержит 
// заданные изначально станции
public class Station {
    // отдельная бензоколонка 
    internal class PetrolStation {
        // создаём текущую очередь машинок к определённой колонке
        LinkedList<Car> cars = new LinkedList<Car>();
        private int maxNumberCars;

        // создание нового заправочного места
        public PetrolStation(int maxNumberCars) { 
            this.maxNumberCars = maxNumberCars;
        }
        // есть ли место под новую машину
        public bool isPlaceForCar() {
            return cars.Count <= maxNumberCars;
        }

        // добавляем машину, если есть место
        public void addCar(Car car) {
            if (isPlaceForCar()) { 
                cars.AddLast(car);
            }
        }

        // заправляем очередной автомобиль
        public Car fillCar() {
            Car car = cars.First();
            car.setFuelLevel(true);
            cars.RemoveFirst();
            return car;
        }

    
    }
}


// класс для отдельного автомобиля
public class Car {
    // id - уникальный код автомобиля
    private int idCar;
    // fuelLevel - уровень топлива автомобиля
    private bool isFuelFull;

    // конструктор создания нового автомобиля
    public Car(int newId, bool newFuelLevel) {
        idCar = newId;
        isFuelFull = newFuelLevel;
    }

    // установка уровня топлива
    public void setFuelLevel(bool newFuelLevel) { 
        isFuelFull = newFuelLevel;
    }
}


// класс для дороги по которой едут автомобили
public class Road { 

}