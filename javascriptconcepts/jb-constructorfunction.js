function createNewPerson(name) {
    var obj = {};
    obj.name = name;
    obj.greeting = function () {
        console.log('Hi! I\'m ' + this.name + '.');
    };
    return obj;
}


var salva = createNewPerson('Salva');
salva.name;
salva.greeting();


function Class1(name) {
    this.name = name;
    this.greeting = function () {
        console.log('Hi! I\'m ' + this.name + '.');
    };
}

let classInst = new Class1("Hello World").greeting();


function Person(first, last, age, gender, interests) {
    this.name = {
        'first': first,
        'last': last
    };
    this.age = age;
    this.gender = gender;
    this.interests = interests;
    genderTracking = function () {

        return gender == 'male' ? 'He ' : 'She';
    }
    this.bio = function () {
        console.log(this.name.first + ' ' + this.name.last + ' is ' + this.age + ' years old.' + genderTracking() + this.interests[0] + ' and ' + this.interests[1] + '.');
    };
    this.greeting = function () {
        console.log('Hi! I\'m ' + this.name.first + '.');
    };
}

var person1 = new Person('Bob', 'Smith', 32, 'male', ['music', 'skiing']);

person1['age']
person1.interests[1]
person1.bio()