function sum(a, b) {
    console.log(a + b);
}

function calculator(a, b, sumcallback) {
    sumcallback(a, b);
}

calculator(3, 4, sum);


function getData(dataId, getNextData) {

    // 2s
    setTimeout(() => {

        console.log("data", dataId);

        if (getNextData) {
            getNextData();
        }

    }, 2000);

}

// callback Hell
getData(1, () => {
    getData(2, () => {
        getData(3);
    });
});


// by using promise chine
/*

function getData(dataId) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log("data", dataId);
            resolve("success");
        }, 3000);
    });
}

//Promise Chain

getData(1).then((res) => {
    console.log(res);
    getData(2).then(() => {
        console.log(res);
    })
});


// sort form of promise chine

getData(1)
    .then((res) => {
        return getData(2);
    })
    .then((res) => {
        console.log(res);
    });

*/
