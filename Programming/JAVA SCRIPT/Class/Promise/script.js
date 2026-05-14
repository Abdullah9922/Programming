
let promise = new Promise((resolve, reject) => {

    console.log("I am a promise.");
    resolve("123");
});



let promise2 = new Promise((resolve, reject) => {

    console.log("I am a promise bro.");
    reject("some error occurred.");
});



function getData(dataId, getNextData) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {

            console.log("data", dataId);
            resolve("Success");

            if (getNextData) {
                getNextData();
            }
        }, 5000);
    });
}


// use  of promise 
const getPromiseX = () => {
    return new Promise((resolve, reject) => {
        console.log("I am a promise");
        resolve("Success");
    });
};


let promiseX = getPromiseX();

promiseX.then(() => {
    console.log("Promise Fulfiled");
});


// reject
const getPromise2X = () => {
    return new Promise((resolve, reject) => {
        console.log("I am a promise");
        reject("find some error");
    });
};


let promise2X = getPromise2X();

promise2X.catch(() => {
    console.log("Promise not Fulfiled");
});


// promise chine
function asyncFunc1() {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log("data1");
            resolve("success");
        }, 4000);
    });
}

function asyncFunc2() {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log("data2");
            resolve("success");
        }, 4000);
    });
}

console.log("fetching data1....");
let p1 = asyncFunc1();
p1.then((res) => {
    console.log(res);
    console.log("fetching data2....");
    let p2 = asyncFunc2();
    p2.then((res) => {
        console.log(res)
    })
});


// sort form
/*
console.log("fetching data1....");
asyncFunc1().then((res) => {
    console.log("fetching data2....");
    asyncFunc2().then((res) => {});
});

*/


// using promise chine
function getDataY(dataId) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log("data", dataId);
            resolve("success");
        }, 3000);
    });
}


// sort form of promise chine

getDataY(1)
    .then((res) => {
        return getDataY(2);
    })
    .then((res) => {
        console.log(res);
    });

