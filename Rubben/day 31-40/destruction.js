let a = 1;
let b = 2;
[a, b] = [b, a]; // swap a and b
console.log(a, b); // 2, 1

const [a, b, ...rest] = [1, 2, 3, 4, 5];
console.log(a, b, rest); // 1, 2, [3, 4, 5]

function getMinMax(arr) {
  return [Math.min(...arr), Math.max(...arr)];
}

const [min, max] = getMinMax([1, 2, 3, 4, 5]); // destructure the return value
console.log(min, max); // 1, 5
