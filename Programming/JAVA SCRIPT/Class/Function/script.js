function myFunction() {
    // Function body
    console.log("Hello, World!");
}

myFunction(); // Calling the function to execute its code


function myfunction2(msg){
    console.log(msg);
}

myfunction2("Hello, World!"); // Calling the function with an argument

function myfunction3(a, b){
    return a + b;
}
let result = myfunction3(5, 10); // Calling the function and storing the result
console.log(result); // Output: 15

const arrow_sum = (a, b) => a + b; // Arrow function to sum two numbers
let sumResult = arrow_sum(3, 7);
console.log(sumResult); // Output: 10


let arr = [1,2,3,4,5];
arr.forEach(num => console.log(num)); // Using forEach with an arrow function to log each number in the array


let nums=[22,35,78,98];
let squaredNums = nums.map(num => num * num); // Using map to create a new array of squared numbers 
let rem = nums.filter(num => num % 2 === 0); // Using filter to create a new array of even numbers
console.log(squaredNums);
console.log(rem);


// reduce array
let sum = nums.reduce((accumulator, currentValue) => accumulator + currentValue, 0); // Using reduce to sum all numbers in the array    
console.log(sum); // Output: 233


let max = nums.reduce((prev,curr) =>{
    return prev > curr ? prev : curr
});
console.log(max); // Output: 98