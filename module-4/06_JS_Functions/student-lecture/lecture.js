/**
 * All named functions will have the function keyword and
 * a name followed by parentheses.
 * 
 * @returns {number} 1
 */
function returnOne() {
  return 1;
}

/**
 * Functions can also take parameters. These are just variables that are filled
 * in by whoever is calling the function.
 *
 * Also, we don't *have* to return anything from the actual function. This will result in returning "undefined"
 *
 * @param {any} value the value to print to the console
 * @returns {Boolean} true if it completed without error
 */
function printToConsole(value) {
  console.log(value);

  return true;
}

/**
 * Write a function called multiplyTogether that multiplies two numbers together.
 *
 * @param {number} firstParameter the first parameter to multiply
 * @param {number} secondParameter the second parameter to multiply
 */
function multiplyTogether(firstParameter, secondParameter){
  /*if(firstParameter === undefined){
    first = 0;
  }
  if(secondParameter === undefined){
    secondParameter = 0;
  }
  */
  return firstParameter * secondParameter;
}


/**
 * This version makes sure that no parameters are ever missing.
 * Call this function multiplyNoUndefined
 *
 * @param {number} [firstParameter=0] the first parameter to multiply(defaults to 0)
 * @param {number} [secondParameter=0] the second parameter to multiply(defaults to 0)
 */
 function multiplyNoUndefined(firstParameter=0, secondParameter=0){
   return firstParameter * secondParameter;
 }


/**
 * Write a function called log all parameters that logs any parameters you give it to the console.
 * Design it so that it can take in 0 to unlimited parameters using ...
 * @param {...any} inputValues the items to log. Can be empty or many many items long
 */

function logAllParameters(...inputValues){
  for(let i=0; i < inputValues.length; i++){
    console.log(inputValues[i]);
  }
}
function logAllParametersOldWay(){
  const inputValues = arguments;
  console.log(arguments);
  for(let i=0; i < inputValues.length; i++){
    console.log(inputValues[i]);
  }
}
 
// FLOW AND SCOPE

/**
 * Functions can return earlier before the end of the function. This could be useful
 * in circumstances where you may not need to perform additional instructions or have to
 * handle a particular situation.
 * In this example, if the firstParameter is equal to 0, we return secondParameter times 2.
 * Observe what's printed to the console in both situations.
 * 
 * @param {number} firstParameter the first parameter
 * @param {number} secondParameter the second parameter
 */
function returnBeforeEnd(firstParameter, secondParameter) {
  console.log("This will always fire.");

  if (firstParameter == 0) {
    console.log("Returning secondParameter times two.");
    return secondParameter * 2;
  }

  //this only runs if firstParameter is NOT 0
  console.log("Returning firstParameter + secondParameter.");
  return firstParameter + secondParameter;
}

/**
 * Scope is defined as where a variable is available to be used.
 *
 * If a variable is declare inside of a block, it will only exist in
 * that block and any block underneath it. Once the block that the
 * variable was defined in ends, the variable disappears.
 */
function scopeTest() {
  // This variable will always be in scope in this function
  let inScopeInScopeTest = true;

  if (true) {
    // this variable lives inside this block and doesn't
    // exist outside of the block
    var scopedToBlock = inScopeInScopeTest;
  }

  // scopedToBlock doesn't exist here so an error will be thrown
  if (inScopeInScopeTest && scopedToBlock) {
    console.log("This won't print!");
  }
}

function createSentenceFromUser(name, age, listOfQuirks = [], separator = ', ') {
  let description = `${name} is currently ${age} years old. Their quirks are: `;

  return description + listOfQuirks.join(separator);
}

// ARROW FUNCTIONS

/**
 * Takes an array and, using forEach and anonymous functions, returns their sum
 *
 * @param {number[]} numbersToSum numbers to add up
 * @returns {number} sum of all the numbers
 */
function sumAllNumbers(numbersToSum) {
    let total = 0;
    numbersToSum.forEach(num => total+= num);

    return total;

}

/**
 * Takes an array and, using reduce and anonymous functions, returns their sum
 *
 * @param {number[]} numbersToSum numbers to add up
 * @returns {number} sum of all the numbers
 */
function sumAllNumbersUsingReduce(numbersToSum) {
    return numbersToSum.reduce((total, currentValue) => total + currentValue, 0);
}

/**
 * Takes an array and, using map and anonymous functions, return a 
 * new array where each number is multiplied by multiplier
 * 
 * @param {number[]} numbersToMultiply the numbers to multiply against multiplier
 * @param {number} multiplier the number to multiply each number by
 * @returns {number[]} the multiplied numbers
 */
function multiplyAll(numbersToMultiply, multiplier) {
    return numbersToMultiply.map(num => num * multiplier);
}
function multiplyForLoop(numbers, multiplier){
  const result = [];
  numbers.forEach(num => {
    const multipliedValue = num * multiplier;
    result.push(multipliedValue);
  });
  return result;
}
/**
 * Takes an array and returns a new array of only numbers that are
 * multiples of 3
 *
 * @param {number[]} numbersToFilter numbers to filter through
 * @returns {number[]} a new array with only those numbers that are
 *   multiples of 3
 */
function isDivisibleByThree(num){
  return num % 3 === 0;
}
function allDivisibleByThree(numbersToFilter) {
 // return numbersToFilter.filter(n => n % 3 === 0);
 //return numbersToFilter.filter(n => isDivisibleByThree(n));
 return numbersToFilter.filter(isDivisibleByThree);
}

/**
 * Returns whether or not number was even
 * @param {number} number the number to check to see if it was even
 * @returns {Boolean} whether or not number was even
 */
function isEven(number) {
  return number % 2 === 0;
}

/**
 * Returns the first number in numbers that is even
 * @param {number[]} numbers the array of numbers
 * @returns {number|undefined} the first even number, or undefined if no even numbers were provided.
 */
function findFirstEvenNumber(numbers) {
  return numbers.find(num => isEven(num));
}
function multByEight(num){
  return num * 8;
}
const mathHelpers = {
  firstEven: findFirstEvenNumber, 
  multiplyByEight: multByEight,

  multiplyByFour: function multByFour(num){
    return num * 4;
  },
  multiplyByTwo: function(num){
    return num * 2;
  },

  multiplyByTwelve: (num) => {
    return num * 12;
  },

  multiplyByTen: (num) => num * 10,
};

const notConsole = {
  log: function(...thingsToLog){

  }
}