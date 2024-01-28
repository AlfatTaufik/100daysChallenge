function stalinSort(arr) {
    let sortedArr = [];
    let maxVal = null;
    for (let val of arr) {
        if (maxVal === null || val >= maxVal) {
            sortedArr.push(val);
            maxVal = val;
        }
    }
    return sortedArr;
}
let arr = [28, 21, 4, 83, 5, 46, 95, 81, 23, 8, 53, 24, 9, 82, 98]
console.log(stalinSort(arr))