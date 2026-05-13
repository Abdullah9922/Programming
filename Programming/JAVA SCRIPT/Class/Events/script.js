let bta1 = document.querySelector("#bta1");

bta1.onclick = () => {
    console.log("Butten is clicked");
    let a = 5;
    a++;
    console.log(a);
}

let box = document.querySelector(".box");
box.onmouseover = () => {
    console.log("YES");
}


let btn = document.querySelector("#b1");

btn.addEventListener("click", () => {
    console.log("Hi tume chap diso.");
});


btn.addEventListener("click", () => {
    console.log("tume chap dila kano.");
});



let mode = document.querySelector("#mode");
let currMode = "Light";
mode.addEventListener("click", () => {
    console.log("Your are trying to change to mode.");

    if (currMode === "Light") {
        currMode = "Dark";
        document.querySelector("body").style.backgroundColor = "Black";
    }
    else {
        currMode = "Light";
        document.querySelector("body").style.backgroundColor = "White";

    }

    console.log(currMode);
});


let mody = document.querySelector("#mody");
let body = document.querySelector("body");

let currmode = "Light";

mody.addEventListener("click", () => {

    if(currmode === "Light"){
        body.classList.add("dark");
        body.classList.remove("lite");
        currmode = "Dark";
    }

    else{
        body.classList.add("lite");
        body.classList.remove("dark");
        currmode = "Light";
    }

    console.log(currmode);
});

