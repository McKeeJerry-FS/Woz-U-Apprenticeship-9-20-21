// Step 1:

const arr = [
    {"name":"chevy", "count": 2},
    {"name":"ford", "count": 5},
    {"name":"acura", "count": 3},
    {"name":"honda", "count": 16},
];

const newArr = [...arr];

for(let i= 0; i < arr.length; i++){
    if(arr[i].name === "ford" ){
        newArr.push(arr[i]);
    }
}

function isEnough(value) {
    return value >= newArr;
}

const filtered = [...arr].filter(isEnough)
console.log("Filter results:", newArr, filtered);


// Step 2:

const arr2 = ['Bill', 'Joe', 'Emily', 'Andrea'];
const newStudents = ['Andrew', 'Tasha', 'Carol', 'George'];

// combining the two arrays
const newArray = [...arr2, ...newStudents];

function addNewStudent(array, newArray) {
    for(let i = 0; i < newArray.length; i++) {
        array.push(newArray[i]);
    }
}

addNewStudent(arr, newStudents);
// displaying the combined array
console.log(newArray);