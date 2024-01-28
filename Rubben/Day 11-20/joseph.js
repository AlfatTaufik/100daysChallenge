function josephus(arr, k){
    let result = [], index = 0;
    while (arr.length > 0) {
        index = (index + k - 1) % arr.length;
        result.push(arr[index]);
        arr.splice(index, 1);
    }
    return result;
}

console.log(josephus([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 3));
