document.body.style.color="White";

document.getElementById("myid").innerText="This is a heading";
document.getElementsByTagName("p")[0].innerText="This is a paragraph";


let x = document.getElementById("myid");
console.dir(x);
x.style.background="Yellow";
x.style.color="Red";


let y = document.getElementsByClassName("myclass");
console.dir(y);
y[0].style.background="Blue";
y[0].style.color="White";


let firstelement = document.querySelector(".myclass");
console.dir(firstelement);

let allelements = document.querySelectorAll(".myclass");
console.dir(allelements);

let txt = document.querySelector(".myclass");
console.dir(txt);



let divs = document.querySelectorAll(".outerBox");
let i;
for(i=0; i<divs.length; i++){
    divs[i].style.background="Pink";
    divs[i].style.color="Black";
}



let n = document.querySelector("section");
console.log(n);

let id = n.getAttribute("id");
console.log(id);

n.setAttribute("id","mysection");

let newId = n.getAttribute("id");
console.log(newId);

console.log("n.name: " + n.getAttribute("name"));

n.setAttribute("name","Khabib");

console.log("n.name: " + n.getAttribute("name"));
n.style.background="Green";
n.innerText="New Text";
n.style.color="white";
n.style.fontSize="20px";



// create a new element
let newElement = document.createElement("button");
newElement.innerText = "Click Me!";
console.log(newElement);

// append the new element to the body
let xx = document.querySelector("section");
xx.append(newElement);
