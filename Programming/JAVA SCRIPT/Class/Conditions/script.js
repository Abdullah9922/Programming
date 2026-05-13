let a = 3;
let b = 5;

console.log("a + b =", a + b);
console.log("a - b =", a - b);
console.log("a * b =", a * b);
console.log("a / b =", a / b);


alert("Hello World");

let age = prompt("What is your age?");

if (age >= 18) {
    alert("You are an adult.");
}
else {
    alert("You are a minor.");
}

let aa = 5;
let bb = "5";

console.log("aa is equal to bb:", aa == bb); // true
console.log("aa is strictly equal to bb:", aa === bb); // false


//for of loop

let f = "applecherry";

for (let x of f) {
    console.log(x);
}



let fruits = ["apple", "banana", "cherry"];

for (let fruit of fruits) {
    console.log(fruit);
}


const person = {
    name: "John",
    age: 30,
    city: "New York"
};

for (let key in person) {
    console.log(key + ": " + person[key]);
}


let obj = {
    item: "pen",
    price: 10,
};

let output = 'the price of ' + obj.item +  'is ' + obj.price + 'Taka';
console.log(output); 


// template literals

let output2 = `the price of ${obj.item} is ${obj.price} Taka`;
console.log(output2);

console.log(obj.item.length);
console.log(obj.item.toUpperCase());
console.log(obj.item.toLowerCase());

console.log(obj.item.trim("pen"));


// arrays

let marks = [85, 90, 78, 92, 88];

console.log("Marks:", marks);
console.log("First mark:", marks[0]);
console.log("Number of marks:", marks.length);


let fruits2 = ["apple", "banana", "cherry"];

fruits2.push("date");
console.log("Fruits after push:", fruits2);


fruits2.unshift("avocado");
console.log("Fruits after unshift:", fruits2);


fruits2.pop();
console.log("Fruits after pop:", fruits2);

fruits2.shift();
console.log("Fruits after shift:", fruits2);


for(let i = 0; i < fruits2.length; i++) {
    console.log(fruits2[i]);
}

for(let fruit of fruits2) {
    console.log(fruit);
}


fruits2.splice(1, 0, "blueberry"); // splice(start_index,remove,replace)
console.log("Fruits after splice:", fruits2);