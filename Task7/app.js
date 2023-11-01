class Driver {
  constructor(fullName, drivingExperience) {
    this.fullName = fullName;
    this.drivingExperience = drivingExperience;
  }
}

class Engine {
  constructor(power, manufacturer) {
    this.power = power;
    this.manufacturer = manufacturer;
  }
}

class Car {
  constructor(brand, carClass, weight, driver, engine) {
    this.brand = brand;
    this.carClass = carClass;
    this.weight = weight;
    this.driver = driver;
    this.engine = engine;
  }

  start() {
    console.log("Поехали");
  }

  stop() {
    console.log("Останавливаемся");
  }

  turnRight() {
    console.log("Поворот направо");
  }

  turnLeft() {
    console.log("Поворот налево");
  }

  toString() {
    return `Марка автомобиля: ${this.brand}\nКласс автомобиля: ${this.carClass}\nВес: ${this.weight}\nВодитель: ${this.driver.fullName}, стаж вождения: ${this.driver.drivingExperience}\nМотор: мощность - ${this.engine.power}, производитель - ${this.engine.manufacturer}`;
  }
}

const driver = new Driver("Каримзода Ардамехр", 4);
const engine = new Engine(1.8, "Opel");
const car = new Car("Astra", "G", 1500, driver, engine);

car.start();
car.turnLeft();
car.stop();

console.log(car.toString());