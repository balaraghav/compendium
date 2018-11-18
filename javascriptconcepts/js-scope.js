function prepareCake(flavor) {
    return function () {
        // Adding debugger
        debugger
        setTimeout(_ => console.log(`Made a ${flavor} cake!`, 1000))
    }
}

const makeCakeLater = prepareCake('banana');


var module = (function () {
    var privateMethod = function () {
        console.log('A private method');
    },
 
    someMethod = function () {
        console.log('A public method');
    },
        anotherMethod = function () {
            console.log('Another public method');
        };
    return {
        someMethod: someMethod,
        anotherMethod: anotherMethod
    };
})();


!function letMeLog(){ console.log("Hello World!")}();

(function (){
    console.log("Me again!");
})();