//For loop
for (let i = 0; i < 10; i++) {
    console.info(i)
}

//While loop
let i = 0;
while (i < 5) {
    console.info(i)
    i++
}

//Do While
let j = 0;
do {
    console.info(j);
    j++;
} while (j < 5);

// For in 
const obj: { [key: string]: number } = { a: 1, b: 2, c: 3 };

for (let key in obj) {
    console.info(key, obj[key]);
}

//For of
const arr = [1, 2, 3, 4, 5];
for (let value of arr) {
    console.info(value);
}

//For each
const arrays = [1, 2, 3, 4, 5];
arr.forEach((value) => {
    console.log(value);
});
