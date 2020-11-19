// SHADOWING

let clickCounter = 0;

function incrementCounter(){
  clickCounter++;// = numClicks + 1;
}

// SPREAD OPERATOR (...) FOR FUNCTIONS

function addUsingRest(...numbers) {
  let sum = 0;
  numbers.forEach(num => sum += num);
  return sum;
}

function add(num1, num2, num3) {
  return num1 + num2 + num3;
}

const myNumbers = [1, 2, 3];

const result = add(...myNumbers);

console.log('Spreading our numbers out results in ', result);

// SPREAD OPERATOR (...) FOR OBJECT CLONING

const myCar = {
  make: 'Honda',
  model: 'Civic',
  color: 'Blue',
  vin: 12345,
}

const friendsCar = {...myCar, hasOnStar: true};
friendsCar.vin = 67890;

console.log('I drive this car', myCar);
console.log('My friend drives this car', friendsCar);


const myPlane = {

  fuelAmount: 0,

  addFuel: function(amount) {
    this.fuelAmount += amount;
  },

  fly: function(distance) {
    this.fuelAmount -= distance * 10;
  }

};