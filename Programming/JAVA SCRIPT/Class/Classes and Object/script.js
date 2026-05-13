const student = {
    fullname: "Ishtyaq Ahmed",
    marks: 94.5,
    printMarks: function() {
        console.log("Marks:- ", this.marks);
    },
};


const employee = {
    calcTax(){
        console.log("Tax rate is 10%");
    },
};


const kiron = {
    salary: 40000,
};


kiron.__proto__ = employee;


class ToyotaCar{

    constructor(){
        console.log("Creatiog a Object.");
    }
    start(){
        console.log("Start");
    }

    stop(){
        console.log("Stop");
    }

    setBrand(b){
        this.brandName = b;
    }
}


let fortuner = new ToyotaCar();
fortuner.setBrand("fortuner");
let lexus = new ToyotaCar();
lexus.setBrand("lexus");


class Parent {
    hello(){
        console.log("hello boys");
    }
}

class child extends Parent{}

let obj = new child();



class person {

    constructor(){
        this.species = "Manus";
    }
    eat () {
        console.log("Eat");
    }

    sleep(){
        console.log("sleep");
    }

    work(){
        console.log("Do nothing");
    }
}


class Engineer extends person {
    constructor(bbb){
        super();
        this.branch = bbb;
    }
    x (){
        console.log("Go to Office");
    }

    work(){
        super.eat();
        console.log("Solve problems");
    }
}


let asif = new Engineer("Chemical engineering");